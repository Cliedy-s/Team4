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
    public partial class UserSettingForm : Axxen.BaseForm
    {

        List<ScreenItem_MasterVO> Screenlist;
        ScreenItemService screenservice = new ScreenItemService();


        UserInfo_Service userservice = new UserInfo_Service();

        public UserSettingForm()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tab_JOlist_DrawItem2);
        }


        private void UserSettingForm_Load(object sender, EventArgs e)
        {
            Screenlist = new List<ScreenItem_MasterVO>();
            Screenlist = screenservice.GetALLScreenItem();

            Dictionary<string, string> cbblist = Screenlist.FindAll(item => item.Use_YN == "Y").ToDictionary(item => item.Screen_Code, item => item.Type); //사용을 하는 그룹만
            cbbscreen.DisplayMember = "Value";
            cbbscreen.ValueMember = "Key";
            cbbscreen.DataSource = new BindingSource(cbblist, null);
            //   lblGroup.Text = cbbGroup.SelectedValue.ToString();
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (userservice.Default_Screen_Code(UserInfo.User_ID, cbbscreen.SelectedValue.ToString()))
                {
                    MessageBox.Show("기본화면이 설정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message,"알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
