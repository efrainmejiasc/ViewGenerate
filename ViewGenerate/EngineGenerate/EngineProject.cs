using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineGenerate
{
    public class EngineProject
    {
        private EngineData Valor = EngineData.Instance();

        private void DeleteFile (string pathArchivo)
        {
            if (File.Exists(pathArchivo))
                File.Delete(pathArchivo);
        }


        private void CreateFolder(string pathArchivo)
        {
            if (!Directory.Exists(pathArchivo))
                Directory.CreateDirectory(pathArchivo);
        }

        public void SaveFile (string pathArchivo)
        {
            if (pathArchivo != null && pathArchivo != "")
            {
                string[] partes = pathArchivo.Split('\\');
                string nombreArchivo = partes[partes.Length - 1];
                DeleteFile(pathArchivo);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathArchivo,false))
                {
                    file.WriteLine(EngineData.UsingBasicas());
                }
            }
        }

    }
}
