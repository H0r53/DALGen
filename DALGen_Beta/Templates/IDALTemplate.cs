using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALGen_Beta
{
    interface IDALTemplate
    {
        void GenerateContent(DALEntity entity, String outputFilePath);
    }
}
