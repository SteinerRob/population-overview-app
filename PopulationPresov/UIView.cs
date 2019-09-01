using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopulationPresov
{
    public class UIView
    {
        public static string GetNameFomPath(string path)
        {
            var tempArray = path.Split('\\');
            return tempArray[tempArray.Length - 1];
            
           
        }
        public static void DrawBtnHide(Button button)
        {
            button.IsAccessible = false;
        }

    }
}
