using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineGenerate
{
    public class EngineProject
    {

        public void GuardarValoresIngresados(string pathArchivo)
        {
            if (pathArchivo != null && pathArchivo != "")
            {
                string[] partes = pathArchivo.Split('\\');
                string nombreArchivo = partes[partes.Length - 1];
                string vLinea = string.Empty;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathArchivo,false))
                {
                  
                        file.WriteLine(vLinea);
                        vLinea = string.Empty;
                }
            }
        }

    }
}
