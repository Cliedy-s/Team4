using Axxen.Util;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;

namespace Axxen.sangyoung
{
    public partial class PPS_MLD_001 : Axxen.GridManageForm
    {
        List<MoldVO> moldList;
        MoldService service = new MoldService();
        public PPS_MLD_001()
        {
            InitializeComponent();
        }

        private void PPS_MLD_001_Load(object sender, EventArgs e)
        {
            DataLoad();
            moldList = service.GetAllMold();
            dgvMainGrid.DataSource = moldList;
        }

        /// <summary>
        /// 데이터 그리드뷰 바인딩
        /// </summary>
        private void DataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "자재번호", "mat_No", true, 60);
        }
    }
}
