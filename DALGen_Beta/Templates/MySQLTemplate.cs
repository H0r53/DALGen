﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace DALGen_Beta
{
    class MySQLTemplate : DALTemplate
    {
        public override void GenerateContent(DALEntity entity, String outputFilePath)
        {
            /****************************
            // Create File
            ****************************/
            string filename = "MySQL_" + entity.EntityName;
            string textBuffer = String.Empty;
            string tempSprocName = String.Empty;
            string tempParamName = String.Empty;
            int count = 0;

            /****************************
            // In the MySQL Schema there is no DB schema prefix, thus we can consider the database name the schema
            ****************************/
            entity.SchemaName = entity.DatabaseName;

            string path = String.Format(@"{0}\\{1}.sql", outputFilePath, filename);
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                /****************************
                // Initial Comments
                ****************************/
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                string version = fvi.FileVersion;

                textBuffer = "/*\n";
                textBuffer += "Author:\t\t\tThis code was generated by DALGen version " + version + " available at https://github.com/H0r53/DALGen \n";
                textBuffer += "Date:\t\t\t" + DateTime.Now.ToShortDateString() + "\n";
                textBuffer += "Description:\tCreates the " + entity.EntityName + " table and respective stored procedures\n";
                textBuffer += "\n";
                textBuffer += "*/\n";
                sw.WriteLine(textBuffer);

                /****************************
                // Generate DB Schema
                ****************************/

                // Set Database Instance
                textBuffer = "\n";
                textBuffer += "USE " + entity.DatabaseName + ";\n";
                textBuffer += "\n";
                sw.WriteLine(textBuffer);


                // Create Table
                textBuffer = "\n";
                textBuffer += "--------------------------------------------------------------\n";
                textBuffer += "-- Create table\n";
                textBuffer += "--------------------------------------------------------------\n";
                textBuffer += "\n";
                sw.WriteLine(textBuffer);

                textBuffer = "\n";
                textBuffer += "CREATE TABLE `" + entity.SchemaName + "`.`" + entity.EntityName + "` (\n";
                count = 0;
                foreach (var attribute in entity.Attributes)
                {
                    textBuffer += attribute.AttributeName + " " + GetDataTypeString(attribute.DataType, attribute.AttributeSize);
                    textBuffer += (attribute.AutoIncrement) ? " AUTO_INCREMENT" : "";
                    if (++count < entity.Attributes.Count)
                    {
                        textBuffer += ",\n";
                    }
                }

                // Add contraints
                count = 0;
                var listcount = entity.Attributes.Where(x => x.IsPrimaryKey || x.IsForeignKey).ToList().Count;
                foreach (var attribute in entity.Attributes.Where(x => x.IsPrimaryKey || x.IsForeignKey).ToList())
                {
                    if (count < listcount)
                        textBuffer += ",";
                    textBuffer += "\n";

                    if (attribute.IsPrimaryKey)
                    {
                        textBuffer += "CONSTRAINT pk_" + entity.EntityName + "_" + attribute.AttributeName
                                   + " PRIMARY KEY (" + attribute.AttributeName + ")\n";
                    }
                    else if (attribute.IsForeignKey)
                    {
                        textBuffer += "CONSTRAINT fk_" + entity.EntityName + "_" + attribute.AttributeName + "_" + attribute.ReferenceEntity + "_"
                                   + attribute.ReferenceAttribute + " FOREIGN KEY (" + attribute.AttributeName + ") REFERENCES "
                                   + attribute.ReferenceEntity + " (" + attribute.ReferenceAttribute + ")\n";
                    }
                    ++count;
                }

                textBuffer += ");\n";
                sw.WriteLine(textBuffer);

                /****************************
                // Generate Sprocs
                ****************************/
                textBuffer = "\n";
                textBuffer += "--------------------------------------------------------------\n";
                textBuffer += "-- Create default SCRUD sprocs for this table\n";
                textBuffer += "--------------------------------------------------------------\n";
                textBuffer += "\n";
                sw.WriteLine(textBuffer);

                // Load
                tempSprocName = "`" + entity.SchemaName + "`.`usp_" + entity.EntityName + "_Load`";
                textBuffer = "DELIMITER //\n";
                textBuffer += "CREATE PROCEDURE " + tempSprocName + "\n";
                textBuffer += "(\n";

                count = 0;
                foreach (var pk in entity.Attributes.Where(x => x.IsPrimaryKey).ToList())
                {
                    tempParamName = "param" + pk.AttributeName + " " + GetDataTypeString(pk.DataType, pk.AttributeSize);
                    textBuffer += "\t IN " + tempParamName;
                    if (++count < entity.Attributes.Where(x => x.IsPrimaryKey).ToList().Count)
                        textBuffer += ",";
                    textBuffer += "\n";
                }

                textBuffer += ")\n";
                textBuffer += "BEGIN\n";
                textBuffer += "\tSELECT\n";

                count = 0;
                foreach (var attribute in entity.Attributes)
                {
                    textBuffer += "\t\t`" + entity.EntityName + "`.`" + attribute.AttributeName + "` AS " + "`" + attribute.AttributeName + "`";
                    if (++count < entity.Attributes.Count)
                        textBuffer += ",";
                    textBuffer += "\n";
                }
                textBuffer += "\tFROM `" + entity.EntityName + "`\n";
                textBuffer += "\tWHERE ";

                count = 0;
                listcount = entity.Attributes.Where(x => x.IsPrimaryKey).ToList().Count;
                foreach (var pk in entity.Attributes.Where(x => x.IsPrimaryKey).ToList())
                {
                    if (count++ != 0)
                        textBuffer += "\t\tAND ";
                    else
                        textBuffer += "\t\t";

                    tempParamName = "param" + pk.AttributeName;
                    textBuffer += "`" + entity.EntityName + "`.`" + pk.AttributeName + "` = " + tempParamName;

                    if (count == listcount)
                        textBuffer += ";";
                    textBuffer += "\n";
                }
                textBuffer += "END //\n";
                textBuffer += "DELIMITER ;\n";
                sw.WriteLine(textBuffer);


                // LoadAll
                tempSprocName = "`" + entity.SchemaName + "`.`usp_" + entity.EntityName + "_LoadAll`";
                textBuffer = "DELIMITER //\nCREATE PROCEDURE " + tempSprocName + "()\n";
                textBuffer += "BEGIN\n";
                textBuffer += "\tSELECT\n";

                count = 0;
                foreach (var attribute in entity.Attributes)
                {
                    textBuffer += "\t\t`" + entity.EntityName + "`.`" + attribute.AttributeName + "` AS " + "`" + attribute.AttributeName + "`";
                    if (++count < entity.Attributes.Count)
                        textBuffer += ",";
                    textBuffer += "\n";
                }
                textBuffer += "\tFROM `" + entity.EntityName + "`;\n";
                textBuffer += "END //\nDELIMITER ;\n";
                sw.WriteLine(textBuffer);

                // Add
                tempSprocName = "`" + entity.SchemaName + "`.`usp_" + entity.EntityName + "_Add`";
                textBuffer = "DELIMITER //\nCREATE PROCEDURE " + tempSprocName + "\n";
                textBuffer += "(\n";

                count = 0;
                foreach (var pk in entity.Attributes.Where(x => !x.IsPrimaryKey).ToList())
                {
                    tempParamName = " IN param" + pk.AttributeName + " " + GetDataTypeString(pk.DataType, pk.AttributeSize);
                    textBuffer += "\t" + tempParamName;
                    if (++count < entity.Attributes.Where(x => !x.IsPrimaryKey).ToList().Count)
                        textBuffer += ",";
                    textBuffer += "\n";
                }

                textBuffer += ")\n";
                textBuffer += "BEGIN\n";
                textBuffer += "\tINSERT INTO `" + entity.EntityName + "` (";

                count = 0;
                foreach (var attribute in entity.Attributes.Where(x => !x.IsPrimaryKey).ToList())
                {
                    textBuffer += attribute.AttributeName;
                    if (++count < entity.Attributes.Where(x => !x.IsPrimaryKey).ToList().Count)
                        textBuffer += ",";
                    else
                        textBuffer += ")\n";
                }
                textBuffer += "\tVALUES (";
                count = 0;
                foreach (var pk in entity.Attributes.Where(x => !x.IsPrimaryKey).ToList())
                {
                    tempParamName = "param" + pk.AttributeName;
                    textBuffer += tempParamName;
                    if (++count < entity.Attributes.Where(x => !x.IsPrimaryKey).ToList().Count)
                        textBuffer += ", ";
                    else
                        textBuffer += ");\n";
                }
                textBuffer += "\t-- Return last inserted ID as result\n";
                textBuffer += "\tSELECT LAST_INSERT_ID() as id;\n";
                textBuffer += "END //\n";
                textBuffer += "DELIMITER ;\n\n";
                sw.WriteLine(textBuffer);


                // Update
                tempSprocName = "`" + entity.SchemaName + "`.`usp_" + entity.EntityName + "_Update`";
                textBuffer = "DELIMITER //\nCREATE PROCEDURE " + tempSprocName + "\n";
                textBuffer += "(\n";

                count = 0;
                foreach (var pk in entity.Attributes)
                {
                    tempParamName = "IN param" + pk.AttributeName + " " + GetDataTypeString(pk.DataType, pk.AttributeSize);
                    textBuffer += "\t" + tempParamName;
                    if (++count < entity.Attributes.Count)
                        textBuffer += ",";
                    textBuffer += "\n";
                }

                textBuffer += ")\n";
                textBuffer += "BEGIN\n";
                textBuffer += "\tUPDATE `" + entity.EntityName + "`\n";
                textBuffer += "\tSET ";
                count = 0;
                foreach (var pk in entity.Attributes.Where(x => !x.IsPrimaryKey).ToList())
                {
                    tempParamName = "param" + pk.AttributeName;
                    textBuffer += pk.AttributeName + " = " + tempParamName;
                    if (++count < entity.Attributes.Where(x => !x.IsPrimaryKey).ToList().Count)
                        textBuffer += "\n\t\t,";
                    else
                        textBuffer += "\n";
                }

                textBuffer += "\tWHERE";
                count = 0;
                listcount = entity.Attributes.Where(x => x.IsPrimaryKey).ToList().Count;
                foreach (var pk in entity.Attributes.Where(x => x.IsPrimaryKey).ToList())
                {
                    if (count++ != 0)
                        textBuffer += "\t\tAND ";
                    else
                        textBuffer += "\t\t";

                    tempParamName = "param" + pk.AttributeName;
                    textBuffer += "`" + entity.EntityName + "`.`" + pk.AttributeName + "` = " + tempParamName;

                    if (count == listcount)
                        textBuffer += ";";
                    textBuffer += "\n";
                }

                textBuffer += "END //\n";
                textBuffer += "DELIMITER ;\n\n";
                sw.WriteLine(textBuffer);

                // Delete
                tempSprocName = "`" + entity.SchemaName + "`.`usp_" + entity.EntityName + "_Delete`";
                textBuffer = "DELIMITER //\nCREATE PROCEDURE " + tempSprocName + "\n";
                textBuffer += "(\n";

                count = 0;
                foreach (var pk in entity.Attributes.Where(x => x.IsPrimaryKey))
                {
                    tempParamName = "IN param" + pk.AttributeName + " " + GetDataTypeString(pk.DataType, pk.AttributeSize);
                    textBuffer += "\t" + tempParamName;
                    if (++count < entity.Attributes.Where(x => x.IsPrimaryKey).ToList().Count)
                        textBuffer += ",";
                    textBuffer += "\n";
                }

                textBuffer += ")\n";
                textBuffer += "BEGIN\n";
                textBuffer += "\tDELETE FROM `" + entity.EntityName + "`\n";
                textBuffer += "\tWHERE";
                count = 0;
                listcount = entity.Attributes.Where(x => x.IsPrimaryKey).ToList().Count;
                foreach (var pk in entity.Attributes.Where(x => x.IsPrimaryKey).ToList())
                {
                    if (count++ != 0)
                        textBuffer += "\t\tAND ";
                    else
                        textBuffer += "\t\t";

                    tempParamName = "param" + pk.AttributeName;
                    textBuffer += "`" + entity.EntityName + "`.`" + pk.AttributeName + "` = " + tempParamName;

                    if (count == listcount)
                        textBuffer += ";";
                    textBuffer += "\n";
                }

                textBuffer += "END //\n";
                textBuffer += "DELIMITER ;\n\n";
                sw.WriteLine(textBuffer);


                // Search
                tempSprocName = "`" + entity.SchemaName + "`.`usp_" + entity.EntityName + "_Search`";

                textBuffer = "DELIMITER //\nCREATE PROCEDURE " + tempSprocName + "\n";
                textBuffer += "(\n";

                count = 0;
                foreach (var pk in entity.Attributes)
                {
                    tempParamName = "IN param" + pk.AttributeName + " " + GetDataTypeString(pk.DataType, pk.AttributeSize);
                    textBuffer += "\t" + tempParamName;
                    if (++count < entity.Attributes.Count)
                        textBuffer += ",";
                    textBuffer += "\n";
                }

                textBuffer += ")\n";
                textBuffer += "BEGIN\n";
                textBuffer += "\tSELECT\n";

                count = 0;
                foreach (var attribute in entity.Attributes)
                {
                    textBuffer += "\t\t`" + entity.EntityName + "`.`" + attribute.AttributeName + "` AS " + "`" + attribute.AttributeName + "`";
                    if (++count < entity.Attributes.Count)
                        textBuffer += ",";
                    textBuffer += "\n";
                }

                textBuffer += "\tFROM `" + entity.EntityName + "`\n";
                textBuffer += "\tWHERE\n";
                count = 0;
                listcount = entity.Attributes.Count;
                foreach (var pk in entity.Attributes)
                {
                    if (count++ != 0)
                        textBuffer += "\t\tAND ";
                    else
                        textBuffer += "\t\t";

                    tempParamName = "param" + pk.AttributeName;

                    if (IsDateDataType(pk.DataType) && pk.DataType != DataType.DATE)
                    {
                        // For general purposes, any Date comparisons will be based on the calendar date and not the time element
                        textBuffer += "COALESCE(CAST(" + entity.EntityName + ".`" + pk.AttributeName + "` AS DATE), CAST(GETDATE() AS DATE)) = COALESCE(CAST(";
                        textBuffer += tempParamName + " AS DATE),CAST(" + entity.EntityName + ".`" + pk.AttributeName + "` AS DATE), CAST(GETDATE() AS DATE))";
                    }
                    else
                    {
                        textBuffer += "COALESCE(" + entity.EntityName + ".`" + pk.AttributeName + "`," + GetDataTypeDefaultValue(pk.DataType) + ") = COALESCE(";
                        textBuffer += tempParamName + "," + entity.EntityName + ".`" + pk.AttributeName + "`," + GetDataTypeDefaultValue(pk.DataType) + ")";
                    }

                    if (count == listcount)
                        textBuffer += ";";
                    textBuffer += "\n";
                }
                textBuffer += "END //\n";
                textBuffer += "DELIMITER ;\n\n";
                sw.WriteLine(textBuffer);

                sw.Close();
            }
        }       
    }
}