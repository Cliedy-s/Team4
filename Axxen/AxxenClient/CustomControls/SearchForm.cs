using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Axxen.CustomControls.ATextBox_FindNameByCode;

namespace Axxen.CustomControls
{
    public partial class SearchForm : Axxen.FreeForm
    {
        public string ResultCode { get; set; }
        public string ResultName { get; set; }
        types type;
        public SearchForm(types type)
        {
            InitializeComponent();
            this.type = type;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            //TODO - ( SearchForm ) 검색 결과 출력하기
            switch (type)
            {
                case types.Users:
                    break;
                case types.Authoritys:
                    break;
                case types.Systems:
                    break;
                case types.Processes:
                    break;
                case types.Items:
                    break;
                case types.Facility:
                    break;
                case types.Errors:
                    break;
                case types.NonOperations:
                    break;
                case types.UserDefinitions:
                    break;
                case types.PackingGrades:
                    break;
                case types.WorkCenters:
                    break;
                case types.GVs:
                    break;
                case types.Workers:
                    break;
            }
        }

        private void dgvSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO - CellDoubleClick시 값을 ATextBox_FindNameByCode로 전달하는 코딩
            // this.ResultCode = ;
            // this.ResultName = ;
            this.Close();
        }
    }
}
