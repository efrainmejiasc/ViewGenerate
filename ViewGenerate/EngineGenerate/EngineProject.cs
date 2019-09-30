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

        private string GetNameFile(string nombreArchivo , string tipo)
        {
            if (tipo == "cs")
                nombreArchivo = nombreArchivo.Substring(0, nombreArchivo.Length - 3);
            else if(tipo == "xaml")
                nombreArchivo = nombreArchivo.Substring(0, nombreArchivo.Length - 5);

            return nombreArchivo;
        }

        private NameSpace GetNameSpace(string pathArchivo,string tipo)
        {
            string[] partes = pathArchivo.Split('\\');
            NameSpace I = new NameSpace();
            I.NombreApp = partes[partes.Length - 3];
            I.NombreCarpeta = partes[partes.Length - 2];
            I.NombreArchivo = GetNameFile(partes[partes.Length - 1],tipo);
            return I;
        }

        public bool SaveFileContenCs (string pathArchivo)
        {
            if (pathArchivo == null || pathArchivo == "")
                return false;
            NameSpace I = GetNameSpace(pathArchivo,"cs");
            DeleteFile(pathArchivo);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathArchivo, true))
            {
                file.WriteLine(EngineData.UsingBasicasCs());
                file.WriteLine(EngineData.MainShemaCs(I.NombreApp , I.NombreCarpeta, I.NombreArchivo));
            }
            return true;
        }

        public bool SaveFileContenXaml(string pathArchivo)
        {
            if (pathArchivo == null || pathArchivo == "")
                return false;

            DeleteFile(pathArchivo);
            DeleteFile(pathArchivo + ".cs");
            CreateXaml(pathArchivo);
            CreateXamlCs(pathArchivo);
            return true;
        }

        public bool CreateXaml (string pathArchivo)
        {
            NameSpace I = GetNameSpace(pathArchivo,"xaml");
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathArchivo, true))
            {
                file.WriteLine(EngineData.MainShemaXaml(I.NombreApp, I.NombreCarpeta, I.NombreArchivo));
            }
            return true;
        }

        public bool CreateXamlCs(string pathArchivo)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathArchivo + ".cs", true))
            {
                NameSpace I = GetNameSpace(pathArchivo, "xaml");
                file.WriteLine(EngineData.UsingBasicasXamlCs());
                file.WriteLine(EngineData.MainShemaXamlCs(I.NombreApp, I.NombreCarpeta, I.NombreArchivo));
            }
            return true;
        }

    }
}
