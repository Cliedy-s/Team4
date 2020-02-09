using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;

namespace Axxen
{
    public partial class MSS_SYS_009 : Axxen.BaseForm
    {
        List<Sys_NoticeVO> syslist;
        Sys_NoticeService sysservice = new Sys_NoticeService();

        public MSS_SYS_009()
        {
            InitializeComponent();
        }

        private void MSS_SYS_009_Load(object sender, EventArgs e)
        {
            dtpstart.Value = DateTime.Now;
            dtpEnd.MaxDate = DateTime.Now;

       

            DatagridviewDesigns.SetDesign(dgvsys);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvsys, "공지시작일자", "Notice_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvsys, "공지종료일자", "Notice_End", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvsys, "공지제목", "Title", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvsys, "공지내역", "Description", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvsys, "공지참조", "Notice_Rtf", true, 210, default, true);

            syslist = new List<Sys_NoticeVO>();
            syslist = sysservice.GetAllSys_notice();
            dgvsys.DataSource = syslist;
        }
    }
}
