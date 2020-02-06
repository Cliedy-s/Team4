using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VO;

namespace Axxen
{
    public partial class MSS_SYS_001_1 : Axxen.BaseForm
    {
        List<MenuTree_Master_VO> menulist; //메뉴
        MainForm_Service service = new MainForm_Service();
     
        public MSS_SYS_001_1()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tab_JOlist_DrawItem2);
        }
        private void MSS_SYS_001_1_Load(object sender, EventArgs e)
        {
         
            ControlSetting();
            lblday1.Text = DateTime.Now.ToShortDateString();         
            lblemp1.Text = UserInfo.User_Name;
            lblday2.Text = DateTime.Now.ToShortDateString();
            lblemp2.Text = UserInfo.User_Name;

        }
        /// <summary>
        /// 콤보박스 세팅
        /// </summary>
        private void ControlSetting() // 콤보박스 세팅
        {
            menulist = service.GetAll_MenuTree_Master();        
            Dictionary<string, string> pcbblist = menulist.FindAll(item => item.Parent_Screen_Code == null).ToDictionary(item => item.Screen_Code, item => item.Screen_Name);
            cbbParent.DisplayMember = "Value";
            cbbParent.ValueMember = "Key";
            cbbParent.DataSource = new BindingSource(pcbblist, null);
            lblParent.Text = cbbParent.SelectedValue.ToString();


            Dictionary<string, string> ccbblist = menulist.FindAll(item => item.Parent_Screen_Code != null).ToDictionary(item => item.Screen_Code, item => item.Screen_Name);
            cbbScreenname.DisplayMember = "Value";
            cbbScreenname.ValueMember = "Key";
            cbbScreenname.DataSource = new BindingSource(ccbblist, null);
            lblscreencode.Text = cbbScreenname.SelectedValue.ToString();
        }
        private void tab_JOlist_DrawItem2(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.NavajoWhite, e.Bounds);

            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("돋움", 12.0f, FontStyle.Regular, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));

        }

        private void CbbParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblParent.Text = cbbParent.SelectedValue.ToString();
        }
        private void Btnson_Click(object sender, EventArgs e)
        {
           

            try
            {

                if (!string.IsNullOrEmpty(lblscreencode.Text) && !string.IsNullOrEmpty(cbbScreenname.Text) )
                {

                    MenuTree_Master_VO additem = new MenuTree_Master_VO()
                    {
                        Parent_Screen_Code = lblParent.Text,
                        Screen_Code = lblscreencode.Text,
                        Screen_Name = cbbScreenname.Text,
                        Ins_Date = Convert.ToDateTime(lblday1.Text),
                        Ins_Emp = lblemp1.Text
                    };


                    if (service.InsertMenuTree_Master_VO(additem))
                    {


                        MessageBox.Show("저장 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("이미 등록된 검사항목입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("필수 항목을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.Log.WriteError(err.Message);
            }




        }

        private void AButton1_Click(object sender, EventArgs e)
        {
         
            try
            {

                if (!string.IsNullOrEmpty(txtparentcode.Text) && !string.IsNullOrEmpty(txtparentname.Text))
                {

                    MenuTree_Master_VO additem = new MenuTree_Master_VO()
                    {
                        Parent_Screen_Code = "0",
                        Screen_Code = lblscreencode.Text,
                        Screen_Name = cbbScreenname.Text,
                        Ins_Date = Convert.ToDateTime(lblday2.Text),
                        Ins_Emp = lblemp2.Text
                    };

                    if (service.InsertMenuTree_Master_VO(additem))
                    {


                        MessageBox.Show("저장 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("이미 등록된 검사항목입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("필수 항목을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.Log.WriteError(err.Message);
            }
        }

        private void CbbScreenname_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblscreencode.Text = cbbScreenname.SelectedValue.ToString();
        }
    }
}
