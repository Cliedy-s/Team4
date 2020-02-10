using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axxen.Util
{
    public static class InitControlUtil
    {
        /// <summary>
        /// 그리드뷰 칼럼 삽입
        /// </summary>
        public static void AddNewColumnToDataGridView(DataGridView dgv, string headerText,
                            string dataPropertyName, bool visibility, int colWidth = 100, DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft, bool isFillAll = false)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.Visible = visibility;
            col.ValueType = typeof(string);
            col.ReadOnly = true;
            col.DefaultCellStyle.Alignment = textAlign;
            col.AutoSizeMode = isFillAll ? DataGridViewAutoSizeColumnMode.Fill : default(DataGridViewAutoSizeColumnMode);
            dgv.Columns.Add(col);
        }

        /// <summary>
        /// 그리드뷰 디자인 설정
        /// </summary>
        public static void SetDGVDesign(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.MultiSelect = false; //열하나만선택

            dgv.AllowUserToResizeColumns = true; // 칼럼 사용자 변경 o
            dgv.AllowUserToResizeRows = false; //사용자가임의로 로우의 크기를 변경시킬수 없게     

            dgv.RowHeadersVisible = false; // 맨왼쪽에 있는 컬럼 삭제
            // dgv.RowHeadersWidth = 20;     // 맨왼쪽에 있는 컬럼 사이즈 변경   

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // 한줄전체선택
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single; //테두리삭제

            dgv.BackgroundColor = Color.White; // Color.FromArgb(248, 241, 233); //그리드뷰 배경색
                                               // dgv.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 175, 175);   // 로우 해더 색설정     
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 239, 245);//홀수행 색변경
            dgv.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(218, 239, 245);   //컬럼 해더 색설정     
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(160, 239, 245); //컬럼색설정
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black; //글리드뷰 안 글자색

            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
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
