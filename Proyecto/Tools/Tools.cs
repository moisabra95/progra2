using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms; 
using MetroFramework.Controls;

namespace Proyecto.Tools
{
    class MyTools
    {

        public static void labelSetTheme(MetroLabel comp, MetroForm form) {
            comp.Theme = form.Theme;
            comp.Style = form.Style;
        }

        public static void textSetTheme(MetroTextBox comp, MetroForm form)
        {
            comp.Theme = form.Theme;
            comp.Style = form.Style;
        }

        public static void btnSetTheme(MetroButton comp, MetroForm form)
        {
            comp.Theme = form.Theme;
            comp.Style = form.Style;
        }

        public static void gridSetTheme(MetroGrid comp, MetroForm form)
        {
            comp.Theme = form.Theme;
            comp.Style = form.Style;
        }
    }

}
