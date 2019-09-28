
using EngineGenerate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewGenerate
{
    public partial class Form1 : Form
    {
       private  EngineProject Funcion = new EngineProject();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = string.Empty;
            this.saveFileDialog1.Filter = " | *.cs";
            this.saveFileDialog1.Title = "Guardar Vista";
            this.saveFileDialog1.DefaultExt = ".cs";
            this.saveFileDialog1.ShowDialog();
            string pathArchivo = saveFileDialog1.FileName;
            Funcion.SaveFile(pathArchivo);
        }
    }
}
