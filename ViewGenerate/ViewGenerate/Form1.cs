
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
            if (CmbTipoPagina.SelectedIndex == -1)
                MessageBox.Show("Debe elejir tipo de pagina", "INFORMACION DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            int tipoPagina = CmbTipoPagina.SelectedIndex;
            string pathArchivo = string.Empty;
            this.saveFileDialog1.FileName = string.Empty;
            switch (tipoPagina)
            {
                case (0): //Pagina de Contenido
                    this.saveFileDialog1.Filter = " | *.xaml";
                    this.saveFileDialog1.DefaultExt = ".xaml";
                    this.saveFileDialog1.Title = "Guardar Pagina";
                    this.saveFileDialog1.ShowDialog();
                    pathArchivo = saveFileDialog1.FileName;
                    CrearPaginaContenidoXaml(pathArchivo);
                    break;
                case (1): //Pagina de Contenido C#
                    this.saveFileDialog1.Filter = " | *.cs";
                    this.saveFileDialog1.DefaultExt = ".cs";
                    this.saveFileDialog1.Title = "Guardar Pagina";
                    this.saveFileDialog1.ShowDialog();
                    pathArchivo = saveFileDialog1.FileName;
                    CrearPaginaContenidoCSharp(pathArchivo);
                    break;
            }
         
        }

        private void CrearPaginaContenidoCSharp(string pathArchivo)
        {
            Funcion.SaveFileContenCs(pathArchivo);
        }

        private void CrearPaginaContenidoXaml(string pathArchivo)
        {
            Funcion.SaveFileContenXaml(pathArchivo);
        }
    }
}
