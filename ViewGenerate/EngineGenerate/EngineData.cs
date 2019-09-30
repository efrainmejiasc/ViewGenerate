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

        
        public static StringBuilder UsingBasicasCs()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("using System;" + Environment.NewLine);
            sb.Append("using System.Collections.Generic;" + Environment.NewLine);
            sb.Append("using System.Linq;" + Environment.NewLine);
            sb.Append("using System.Text;" + Environment.NewLine);
            sb.Append("using Xamarin.Forms;" + Environment.NewLine);
            sb.Append("using System.Threading.Tasks;" + Environment.NewLine);
            return sb;
        }

        public static StringBuilder UsingBasicasXamlCs()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("using System;" + Environment.NewLine);
            sb.Append("using System.Collections.Generic;" + Environment.NewLine);
            sb.Append("using System.Linq;" + Environment.NewLine);
            sb.Append("using System.Text;" + Environment.NewLine);
            sb.Append("using System.Threading.Tasks;" + Environment.NewLine);
            sb.Append("using Xamarin.Forms;" + Environment.NewLine);
            sb.Append("using Xamarin.Forms.Xaml;" + Environment.NewLine);
            return sb;
        }

        public static StringBuilder MainShemaCs(string nombreAplicacion , string nombreCarpeta , string nombreArchivo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine + Environment.NewLine + Environment.NewLine);
            sb.Append("namespace " + nombreAplicacion  + "." + nombreCarpeta + Environment.NewLine);
            sb.Append("{" + Environment.NewLine);
            sb.Append("   public class " + nombreArchivo  + " : ContentPage" + Environment.NewLine);
            sb.Append("   {" + Environment.NewLine);
            sb.Append("       public " + nombreArchivo + "()" + Environment.NewLine);
            sb.Append("       {" + Environment.NewLine);
            sb.Append("            ScrollView scroll = new ScrollView();" + Environment.NewLine);
            sb.Append("            StackLayout stack = new StackLayout" + Environment.NewLine);
            sb.Append("               {" + Environment.NewLine);
            sb.Append("                    Children = {" + Environment.NewLine);
            sb.Append("                                 new Label { Text =" + "\"Welcome to Xamarin.Forms!" + "\" }" + Environment.NewLine);
            sb.Append("                    }" + Environment.NewLine);
            sb.Append("               };" + Environment.NewLine);
            sb.Append("           scroll.Content = stack;" + Environment.NewLine);
            sb.Append("           Content = scroll;" + Environment.NewLine);
            sb.Append("       }" + Environment.NewLine);
            sb.Append("   }" + Environment.NewLine);
            sb.Append("}" + Environment.NewLine);
            return sb;
        }

        public static StringBuilder MainShemaXaml(string nombreAplicacion, string nombreCarpeta, string nombreArchivo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<?xml version=" + "\"1.0" + "\"" + " encoding=" + "\"utf-8" + "\" ?>" + Environment.NewLine);
            sb.Append("<ContentPage xmlns=" + "\""  + "http://xamarin.com/schemas/2014/forms" + "\" ");
            sb.Append("xmlns:x=" +"\"" + "http://schemas.microsoft.com/winfx/2009/xaml" + "\" ");
            sb.Append("x:Class=" + "\"" + nombreAplicacion + "." + nombreCarpeta + "." + nombreArchivo + "\""  + ">");
            sb.Append("<ContentPage.Content>" + Environment.NewLine);
            sb.Append("     <ScrollView>" + Environment.NewLine);
            sb.Append("         <StackLayout>" + Environment.NewLine);
            sb.Append("              <Label Text = " + "\"" + "Welcome to Xamarin.Forms!" + "\"" + Environment.NewLine);
            sb.Append("                     VerticalOptions = " + "\"" + "CenterAndExpand" + "\""  + Environment.NewLine);
            sb.Append("                     HorizontalOptions = " + "\"" + "CenterAndExpand" + "\""  + "/>" + Environment.NewLine);
            sb.Append("         </StackLayout>" + Environment.NewLine);
            sb.Append("     </ScrollView>" + Environment.NewLine);
            sb.Append ("  </ContentPage.Content>" + Environment.NewLine);
            sb.Append ("</ContentPage>" + Environment.NewLine); 
            return sb;
        }

        public static StringBuilder MainShemaXamlCs(string nombreAplicacion,string nombreCarpeta,string nombreArchivo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Environment.NewLine + Environment.NewLine + Environment.NewLine);
            sb.Append("namespace " + nombreAplicacion + "." + nombreCarpeta + Environment.NewLine);
            sb.Append("{" + Environment.NewLine);
            sb.Append("       [XamlCompilation(XamlCompilationOptions.Compile)]" + Environment.NewLine);
            sb.Append("       public partial class " + nombreArchivo + ": ContentPage" + Environment.NewLine);
            sb.Append("       {" + Environment.NewLine);
            sb.Append("            public " + nombreArchivo + "()" + Environment.NewLine);
            sb.Append("            {" + Environment.NewLine);
            sb.Append("                 InitializeComponent();" + Environment.NewLine);
            sb.Append("            }" + Environment.NewLine);
            sb.Append("       }" + Environment.NewLine);
            sb.Append("}" + Environment.NewLine);
            return sb;
        }

    }
}
