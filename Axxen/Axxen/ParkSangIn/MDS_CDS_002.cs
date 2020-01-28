using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Axxen
{
    public partial class MDS_CDS_002 : Axxen.GridGridManageForm
    {
        public MDS_CDS_002()
        {
            InitializeComponent();
        }

        private void MDS_CDS_002_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);
        }
        /// <summary>
        /// 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MyUpdateShow(object sender, EventArgs e)
        {

          
        }
        /// <summary>
        /// 입력 이벤트 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void InsertFormShow(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    MDS_SDS_002_1 frm = new MDS_SDS_002_1();

                    frm.ShowDialog();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }

        }
        /// <summary>
        /// 새로고침 이벤트 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RefreshFormShow(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
            //    //{
            //    //    GetAllItem();
            //    //    ///
            //    //    ControlSetting();
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message);
            //    Program.Log.WriteError(err.Message);
            //}
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
