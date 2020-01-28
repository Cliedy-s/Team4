using DAC;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using VO;
using static Axxen.CustomControls.ATextBox_FindNameByCode;

namespace Axxen.CustomControls
{
    public partial class SearchForm : Axxen.FreeForm
    {
        public string ResultCode { get; set; }
        public string ResultName { get; set; }
        DataType type;
        public SearchForm(DataType type)
        {
            InitializeComponent();
            this.type = type;
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            //TODO - ( SearchForm ) 검색 결과 출력하기
            switch (type)
            {
                case DataType.Users:
                    break;
                case DataType.Authoritys:
                    break;
                case DataType.Systems:
                    break;
                case DataType.Processes:
                    break;
                case DataType.Items:
                    dgvSearchResult.DataSource = GetData<ItemMaster_Service, Item_MasterVO>("GetAllItem_Master");
                    break;
                case DataType.Facility:
                    break;
                case DataType.Errors:
                    break;
                case DataType.NonOperations:
                    break;
                case DataType.UserDefinitions:
                    break;
                case DataType.PackingGrades:
                    break;
                case DataType.WorkCenters:
                    break;
                case DataType.GVs:
                    break;
                case DataType.GVGroups:
                    break;
                case DataType.Workers:
                    break;
                default:
                    break;
            }
            
        }
        /// <summary>
        /// 데이터를 가져오는 메서드
        /// </summary>
        private List<U> GetData<T, U>(string methodname) 
        {
            object objInstance = Activator.CreateInstance(typeof(T));
            MethodInfo methodInfo = typeof(T).GetMethod(methodname);

            return (List<U>)methodInfo.Invoke(objInstance, null);
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
