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
        public DateTime ADateTimePickerValue1 { get { return aDateTimePicker1.Value; } set { aDateTimePicker1.Value = value; } }
        public DateTime ADateTimePickerValue2 { get { return aDateTimePicker2.Value; } set { aDateTimePicker2.Value = value; } }
        public string ButtonText { get { return aButton1.Text; } set { aButton1.Text = value; } }


        public event SearchButtonClick btnDateTimeSearch_Click;
        public ADateTimePickerSearch()
        {
            InitializeComponent();
        }

        public delegate void SearchButtonClick(object sender, EventArgs args);

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            btnDateTimeSearch_Click?.Invoke(sender, e);           
        }

        private void ADateTimePickerSearch_Load(object sender, EventArgs e)
        {
            aDateTimePicker1.Value = DateTime.Now.AddDays(-7);
            aDateTimePicker2.Value = DateTime.Now;
            aDateTimePicker2.MaxDate = DateTime.Now;

        }

        private void aDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if(aDateTimePicker1.Value > aDateTimePicker2.Value)
            {
                if (MessageBox.Show("날짜를 다시 선택해주세요.", "날짜선택", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    aDateTimePicker2.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
                    aDateTimePicker1.Value = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToShortDateString());
                    aDateTimePicker1.MaxDate = DateTime.Now;
                    aDateTimePicker2.MaxDate = DateTime.Now;
                }
            }
        }

        private void aDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (aDateTimePicker1.Value > aDateTimePicker2.Value)
            {
                if (MessageBox.Show("날짜를 다시 선택해주세요.", "날짜선택", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    aDateTimePicker1.Value = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToShortDateString());
                    aDateTimePicker2.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
                    aDateTimePicker1.MaxDate = DateTime.Now;
                    aDateTimePicker2.MaxDate = DateTime.Now;
                }
            }
        }
    }
}
