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
    public partial class ABigTextBox_FindNameByCode : UserControl
    {
        public string lblNameText { get { return lblName.Text; } set { lblName.Text = value; } }
        public string txtCodeText { get { return txtCode.Text; } set { txtCode.Text = value; } }
        public string txtNameText { get { return txtName.Text; } set { txtName.Text = value; } }

        public ABigTextBox_FindNameByCode()
        {
            InitializeComponent();
            CodeType = types.Users;
        }

        public Font allfont
        {
            get { return this.Font; }
            set
            {
                this.Font = value;
                foreach (Control item in this.Controls)
                    item.Font = value;
            }
        }
        public types codeType;
                public types CodeType { 
            get {
                return this.codeType;
            } 
            set {
                this.codeType = value;
                switch (value)
                {
                    case types.Users:
                        lblNameText = "사용자 그룹";
                        break;
                    case types.Authoritys:
                        lblNameText = "권한 그룹";
                        break;
                    case types.Systems:
                        lblNameText = "시스템 대분류";
                        break;
                    case types.Processes:
                        lblNameText = "공정";
                        break;
                    case types.Items:
                        lblNameText = "품목";
                        break;
                    case types.Facility:
                        lblNameText = "설비";
                        break;
                    case types.Errors:
                        lblNameText = "불량현상 대분류";
                        break;
                    case types.NonOperations:
                        lblNameText = "비가동 대분류";
                        break;
                    case types.UserDefinitions:
                        lblNameText = "사용자정의코드 대분류";
                        break;
                    case types.PackingGrades:
                        lblNameText = "포장등급";
                        break;
                    case types.WorkCenters:
                        lblNameText = "작업장";
                        break;
                    case types.GVs:
                        lblNameText = "대차";
                        break;
                    case types.GVGroups:
                        lblNameText = "대차그룹";
                        break;
                    case types.Workers:
                        lblNameText = "작업자";
                        break;
                    default:
                        break;
                }
            } }

        private void aButton1_Click(object sender, EventArgs e)
        {   // btnSearch Click
            SearchForm searchfrm = new SearchForm(CodeType);
            if(searchfrm.ShowDialog() == DialogResult.OK)
            {
                this.txtCodeText = searchfrm.ResultCode;
                this.txtNameText = searchfrm.ResultName;
            }
        }
    }
}
