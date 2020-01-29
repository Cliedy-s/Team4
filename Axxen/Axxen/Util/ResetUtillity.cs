using Axxen.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Axxen.Util
{
   public class ResetUtillity
    {
        public static void ResetPanelControl(Panel panel)
        {
            foreach (Control item in panel.Controls)
            {

                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                if(item is DateTimePicker)
                {
                   // item.
                }
               
            }

        }
    }
}
