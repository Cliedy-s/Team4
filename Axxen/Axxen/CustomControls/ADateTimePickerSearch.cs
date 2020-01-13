using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axxen.CustomControls
{
    public partial class ADateTimePickerSearch : UserControl
    {
        public string ButtonText { get { return aButton1.Text; } set { aButton1.Text = value; } }
        public event SearchButtonClick btnDateTimeSearch_Click;
        public ADateTimePickerSearch()
        {
            InitializeComponent();

            aDateTimePicker1.Value = DateTime.Now.AddDays(-7);
            aDateTimePicker2.MaxDate = DateTime.Now;
        }
        public delegate EventHandler SearchButtonClick(object sender, EventArgs args);

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            btnDateTimeSearch_Click?.Invoke(sender, e);
        }
    }
}
