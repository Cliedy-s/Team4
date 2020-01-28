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
    public enum DataType { Users, Authoritys, Systems, Processes, Items, Facility, Errors, NonOperations, UserDefinitions, PackingGrades, WorkCenters, GVs, GVGroups, Workers }
    public partial class ATextBox_FindNameByCode : UserControl
    {
        public string lblNameText { get { return lblName.Text; } set { lblName.Text = value; } }
        public string txtCodeText { get { return txtCode.Text; } set { txtCode.Text = value; } }
        public string txtNameText { get { return txtName.Text; } set { txtName.Text = value; } }
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
        public DataType codeType;
        public DataType CodeType { 
            get {
                return this.codeType;
            } 
            set {
                this.codeType = value;
                switch (value)
                {
                    case DataType.Users:
                        lblNameText = "사용자 그룹";
                        break;
                    case DataType.Authoritys:
                        lblNameText = "권한 그룹";
                        break;
                    case DataType.Systems:
                        lblNameText = "시스템 대분류";
                        break;
                    case DataType.Processes:
                        lblNameText = "공정";
                        break;
                    case DataType.Items:
                        lblNameText = "품목";
                        break;
                    case DataType.Facility:
                        lblNameText = "설비";
                        break;
                    case DataType.Errors:
                        lblNameText = "불량현상 대분류";
                        break;
                    case DataType.NonOperations:
                        lblNameText = "비가동 대분류";
                        break;
                    case DataType.UserDefinitions:
                        lblNameText = "사용자정의코드 대분류";
                        break;
                    case DataType.PackingGrades:
                        lblNameText = "포장등급";
                        break;
                    case DataType.WorkCenters:
                        lblNameText = "작업장";
                        break;
                    case DataType.GVs:
                        lblNameText = "대차";
                        break;
                    case DataType.GVGroups:
                        lblNameText = "대차그룹";
                        break;
                    case DataType.Workers:
                        lblNameText = "작업자";
                        break;
                    default:
                        break;
                }
            } }
        public ATextBox_FindNameByCode()
        {
            InitializeComponent();
            CodeType = DataType.Users;
        }

        public delegate void SearchFormClosing(object sender, SearchFormClosingArgs args);
        public event SearchFormClosing DotDotDotFormClosing;

        private void aButton1_Click(object sender, EventArgs e)
        {   // btnSearch Click
            SearchForm searchfrm = new SearchForm(CodeType);
            if(searchfrm.ShowDialog() == DialogResult.OK)
            {
                this.txtCodeText = searchfrm.ResultCode;
                this.txtNameText = searchfrm.ResultName;
                DotDotDotFormClosing?.Invoke(this, new SearchFormClosingArgs() { ResultCode = searchfrm.ResultCode, ResultName = searchfrm.ResultName });
            }
        }
    }
    public class SearchFormClosingArgs :EventArgs
    {
        public string ResultCode { get; set; }
        public string ResultName { get; set; }
    }
}
