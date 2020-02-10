using System.Drawing;
using System.Windows.Forms;

namespace Axxen
{
    public class DatagridviewDesigns
    {
        /// <summary>
        /// 그리드뷰 기본설정
        /// </summary>
        public static void AddNewColumnToDataGridView(DataGridView dgv, string headerText,
      string dataPropertyName, bool visibility, int colWidth = 100, DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft, bool isFillAll =false  )
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.Visible = visibility;
            col.ValueType = typeof(string);
            col.ReadOnly = true;
            col.DefaultCellStyle.Alignment = textAlign;

          //col.AutoSizeMode = isFillAll ? DataGridViewAutoSizeColumnMode.Fill : default(DataGridViewAutoSizeColumnMode);
            dgv.Columns.Add(col);
        }
        /// <summary>
        /// 그리드뷰 기본설정
        /// </summary>
        public static void AddNewColumnToDataGridView_Autosize(DataGridView dgv, string headerText,
      string dataPropertyName, bool visibility, int colWidth = 100, DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft, bool isFillAll = false)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.Visible = visibility;
            col.ValueType = typeof(string);
            col.ReadOnly = true;
            col.DefaultCellStyle.Alignment = textAlign;
             col.AutoSizeMode = isFillAll ? DataGridViewAutoSizeColumnMode.Fill : default(DataGridViewAutoSizeColumnMode);
            dgv.Columns.Add(col);
        }
        public static void SetDesign(DataGridView dgv)
        {
           
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.MultiSelect = false; //열하나만선택
            dgv.AllowUserToResizeColumns = true; //사용자가 열크기 조절못하도록 고정 // 소연 :  답답해서 잠깐 바꿈  //다시 바꿈
            dgv.AllowUserToResizeRows = false; //사용자가임의로 로우의 크기를 변경시킬수 없게     

            dgv.RowHeadersWidth = 40;     // 맨왼쪽에 있는 컬럼 사이즈 변경   
    //    dgv.RowHeadersVisible = false; // 맨왼쪽에 있는 컬럼 삭제
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // 한줄전체선택
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
           dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single; //테두리삭제

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 239, 245);//홀수행 색변경
            dgv.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(218, 239, 245);   //컬럼 해더 색설정     
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(160, 239, 245); //컬럼색설정
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black; //글리드뷰 안 글자색
            dgv.BackgroundColor = Color.White; //그리드뷰 배경색

     
        }

        public static void InitSettingDridView(DataGridView dgv) //사용자 유저
        {
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
