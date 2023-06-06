using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForUP01.Utils
{
    class FormUtils
    {
        public static void InitDefaultDesignToForm(MaterialForm form)
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(form);
            skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue400, Primary.Blue100, Accent.Yellow200, TextShade.WHITE);
        }
    }
}
