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
                if (item is Panel)
                {
                    foreach (Control subitem in item.Controls)
                    {
                        if (subitem is TextBox)
                        {
                            subitem.Text = string.Empty;
                        }
                        if(subitem is NumericUpDown)
                        {
                            subitem.Text = "0";
                        }
                        if(subitem is ComboBox)
                        {
                            subitem.Text = "";
                        }
                    }
                }

                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                if (item is DateTimePicker)
                {
                    item.Text =DateTime.Now.ToShortDateString();
                }

            }

        }
    }
}
