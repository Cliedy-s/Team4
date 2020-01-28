﻿using System;
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
    public partial class ABigTextBox_Searchable : UserControl
    {
        public string LabelText { get { return lblName.Text; } set { lblName.Text = value; } }
        public string TextBoxText { get { return txtValue.Text; } set { txtValue.Text = value; } }
        public TextType TextBoxType { get { return txtValue.txtType; } set { txtValue.txtType = value; } }
        public DataType DataType { get; set; }
        public Font allfont { get { return this.Font; } set {
                this.Font = value;
                foreach (Control item in this.Controls)
                    item.Font = value;
            } }
        public ABigTextBox_Searchable()
        {
            InitializeComponent();
        }

        private void btnSearch_Click_2(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm(DataType);
            if (search.ShowDialog() == DialogResult.OK)
            {
                TextBoxText = search.ResultName;
                //TextBoxText = search.ResultCode;
            }
        }
    }
}
