using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxxenClient.CustomControls
{
    public partial class ALabel_Header : Label
    {
        public ALabel_Header()
        {
            InitializeComponent();
            //Design
            this.Font = new Font("나눔고딕", 25, FontStyle.Bold);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
