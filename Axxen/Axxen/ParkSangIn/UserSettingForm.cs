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
        UserGroupService UserGroupservice = new UserGroupService();
        ScreenItemService screenservice = new ScreenItemService();
        UserInfo_Service userservice = new UserInfo_Service();

        List<UserGroup_MappingVO> userinfoGrouplist; //유저가속한 그룹
        List<ScreenItem_AuthorityVO> AutorScreenlist;
        List<ScreenItem_MasterVO> Screenlist;

        public UserSettingForm()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tab_JOlist_DrawItem2);
        }


        private void UserSettingForm_Load(object sender, EventArgs e)
        {
            userinfoGrouplist = UserGroupservice.GetUserInfoGroup(UserInfo.User_ID); //로그인한 사용자의 그룹권한들
            AutorScreenlist = new List<ScreenItem_AuthorityVO>();
            AutorScreenlist = screenservice.GetUserInfoScreenItem(userinfoGrouplist); //사용자의 권한에 해당하는 스크린코드를 가져온다

            Screenlist = screenservice.GetALLScreenItem();


            List<ScreenItem_MasterVO> tagetscreen=new List<ScreenItem_MasterVO>(); //사용자권한과 스크린비교해서 맞는 스크린만 추출
            for (int i = 0; i < Screenlist.Count; i++)
            {
                for (int j = 0; j < AutorScreenlist.Count; j++)
                {
                    if (Screenlist[i].Screen_Code.Equals(AutorScreenlist[j].Screen_Code))
                    {
                        tagetscreen.Add(Screenlist[i]);
                        break;
                    }
                }
            }


            
            ScreenItem_MasterVO first = new ScreenItem_MasterVO()
            {
                Screen_Code = "0",
                Type = ""
            };
            var level1list = tagetscreen.FindAll(level => level.Use_YN == "Y");
            level1list.Insert(0, first);
            cbbscreen.DisplayMember = "Type";
            cbbscreen.ValueMember = "Screen_Code";
            cbbscreen.DataSource = level1list;

            string[] s01 = UserInfo.S01.Split('/');
            string[] s02 = UserInfo.S02.Split('/');
            string[] s03 = UserInfo.S03.Split('/');
            string[] s04 = UserInfo.S04.Split('/');

            cbbshortcut1.Text = s01[0];
            cbbshortcutsub1.Text = s01[1];

            cbbshortcut2.Text = s02[0];
            cbbshortcutsub2.Text = s02[1];

            cbbshortcut3.Text = s03[0];
            cbbshortcutsub3.Text = s03[1];

            cbbshortcut4.Text = s04[0];
            cbbshortcutsub4.Text = s04[1];

            if (!UserInfo.Default_Screen_Code.Equals("0"))//사용자가 기본설정을 해놓지않았다면 콤보박스에 기본설정 값을 보여주지 않아도된다.
            cbbscreen.Text = tagetscreen.Find(level => level.Screen_Code == UserInfo.Default_Screen_Code).Type;


       

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
                    if (userservice.UpdateShortcutUser_Master(UserInfo.User_ID, cbbshortcut1.Text, cbbshortcutsub1.Text, cbbshortcut2.Text, cbbshortcutsub2.Text, cbbshortcut3.Text, cbbshortcutsub3.Text, cbbshortcut4.Text, cbbshortcutsub4.Text))
                    {
                        MessageBox.Show("기본설정이 저장되었습니다. 다음 로그인부터 적용됩니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                     
                    }
                   
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

        private void BtnPwd_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text.Count() > 7)
            {
                if (txtPwd.Text.Equals(txtPwdChack.Text))
                {
                    if(userservice.UpdateUserPassword(UserInfo.User_ID, txtPwd.Text))
                    {
                        txtPwd.Text = string.Empty;
                        txtPwdChack.Text = string.Empty;
                        MessageBox.Show("비밀번호가 변경되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                    }
                    else
                    {
                        MessageBox.Show("오류", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("비밀번호가 같지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("비밀번호는 8자리 이상 15자리 이하를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
