using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;
using Service;
namespace Axxen
{
    public partial class MSS_CON_002_1 : Axxen.BaseForm
    {
        List<ScreenItem_MasterVO> Screenlist;
        ScreenItemService service = new ScreenItemService();
        public MSS_CON_002_1()
        {
            InitializeComponent();
        }

        private void MSS_CON_002_1_Load(object sender, EventArgs e)
        {

            DatagridviewDesigns.SetDesign(dgvScreenItem);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvScreenItem, "화면코드", "Screen_Code", true, 200, default, true);
    


            Screenlist = new List<ScreenItem_MasterVO>();
            Screenlist= service.GetALLScreenItem();
            dgvScreenItem.DataSource = Screenlist;
    
        }
    }
}
