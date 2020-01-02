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
    public partial class ABorderPanel : Panel
    {
        public Color CommonColor {
            get { return this.BackColor; }
            set {
                this.BackColor = value;

            }
        }
        public ABorderPanel()
        {
            InitializeComponent();
            this.setcolor += panelSet;
            this.setcolor?.Invoke(this, new ColorEventArgs() { color = Color.White }); ;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public delegate void SetColor(object sender, ColorEventArgs args);
        public SetColor setcolor;
        public static void panelSet(object sender, ColorEventArgs args)
        {
            if (sender is ABorderPanel border)
            {
                border.CommonColor = args.color;
            }
        }
    }
    public class ColorEventArgs : EventArgs{
        public Color color { get; set; }
    }
}
