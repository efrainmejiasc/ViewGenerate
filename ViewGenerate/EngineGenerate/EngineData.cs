using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineGenerate
{
    public class EngineData
    {
        private static EngineData valor;
        public static EngineData Instance()
        {
            if ((valor == null))
            {
                valor = new EngineData();
            }
            return valor;
        }

        
        public static StringBuilder UsingBasicas()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("using System;" + Environment.NewLine);
            sb.Append("using System.Collections.Generic;" + Environment.NewLine);
            sb.Append("using System.Linq;" + Environment.NewLine);
            sb.Append("using System.Text;" + Environment.NewLine);
            return sb;
        }
    }
}
