// using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VO;
using Service;
namespace Axxen
{
    public partial class MainForm : Form
    {

        public event EventHandler InsertFormEvent; //추가 폼 이벤트
        public event EventHandler RefreshFormEvent; //새로고침 폼 이벤트
        public event EventHandler MyUpdateEvent; //수정 이벤트

        int CheckBtnIndex = 7;
        bool BookmarkCheck = true; //즐겨찾기 
        bool open = true;
    

        Image CloseImage;

        List<MenuTree_Master_VO> menulist; //메뉴
        List<BookMark_VO> booklist;


        List<UserGroup_MappingVO> userinfoGrouplist; //유저가속한 그룹
        List<ScreenItem_AuthorityVO> userinfoScreenItem;//그룹에속한 화면들
        List<ScreenItem_MasterVO> screenitemlist; //모든 스크린 
        public MainForm()
        {
            InitializeComponent();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {


            LoginForm frm = new LoginForm();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                MainForm_Service service = new MainForm_Service();
                menulist = service.GetAll_MenuTree_Master();
                booklist = service.GetAll_BookMark(UserInfo.User_ID);

                lblName.Text = UserInfo.User_Name;

                ImageList imgList = new ImageList();
                //imgList.Images.Add(Bitmap.FromFile("treeimg.png"));
                imgList.Images.Add(Properties.Resources.treeimg);
                tvMenu.ImageList = imgList;
                tvBookMark.ImageList = imgList;
                this.tabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
                CloseImage = Properties.Resources.x;
                this.tabControl2.Padding = new Point(10, 3);

                UserInformation();
           }
        }

        private void UserInformation()
        {
            UserGroupService service = new UserGroupService();
          
            userinfoGrouplist = service.GetUserInfoGroup(UserInfo.User_ID); //로그인한 사용자의 그룹권한들

            ScreenItemService screenservice = new ScreenItemService();
            userinfoScreenItem = screenservice.GetUserInfoScreenItem(userinfoGrouplist); // 로그인한 사용자의 그룹권한에 사용되는 화면들

            screenitemlist = screenservice.GetALLScreenItem(); //모든스크린

        }


        private void 사용자그룹관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormOpen<MSS_CON_001>(this);
        }

        /// <summary>
        /// 메뉴버튼크릭시 동적으로 메뉴 트리뷰로 생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            tvMenu.Visible = true;
            // 누르는 버튼
            Button btn = (Button)sender;
         
            btn.BackColor = Color.FromArgb(201, 228, 232);
            // 열려있는 트리뷰가 존재하고
            // 현재 열려있는 버튼과 누르는 버튼이 같을 경우(트리뷰를 닫는다)
            if (btn.TabIndex == CheckBtnIndex && open)
            {
                foreach (var item in panelMenu.Controls)
                {
                    Button conBtn;
                    if (item is Button)
                    {
                        conBtn = (Button)item;
                        if (conBtn.TabIndex > CheckBtnIndex)
                        {
                            conBtn.Location = new Point(0, conBtn.Location.Y - tvMenu.Size.Height);
                        }
                    }
                }
                open = false;
                tvMenu.Visible = false;
                btn.BackColor = Color.White;
                return;
            }
            // 열려있는 트리뷰가 존재
            // 현재 열려있는버튼과 누르는 버튼이 다를 경우 
            if (open)
            {
                foreach (var item in panelMenu.Controls)
                {
                    Button conBtn;
                    if (item is Button)
                    {
                        conBtn = (Button)item;
                        //눌려있는 버튼의 Index가 누르는 버튼의 Index보다 적을경우
                        //그 사이에 있는 버튼들을 treeview의 크기만큼 밀어준다
                        if (btn.TabIndex <= CheckBtnIndex)
                        {
                            if (btn.TabIndex < conBtn.TabIndex && CheckBtnIndex >= conBtn.TabIndex)
                            {
                                conBtn.Location = new Point(0, conBtn.Location.Y + tvMenu.Size.Height);
                            }
                        }

                        // 열려있는 버튼과 현재 누른 사이의 버튼들의 위치 재조정
                        if (conBtn.TabIndex <= btn.TabIndex && conBtn.TabIndex > CheckBtnIndex)
                        {
                            conBtn.Location = new Point(0, conBtn.Location.Y - tvMenu.Size.Height);
                            //if (conBtn.TabIndex > CheckBtnIndex)
                            //{
                            //    conBtn.Location = new Point(0, conBtn.Location.Y - trvMenu.Size.Height);
                            //}
                        }
                    }
                }
            }
            // 열려있는 트리뷰가 존재하지 않고
            // 현재 열려있는버튼과 누르는 버튼이 다를 경우 
            else
            {
                foreach (var item in panelMenu.Controls)
                {
                    Button conBtn;
                    if (item is Button)
                    {
                        conBtn = (Button)item;
                        if (conBtn.TabIndex > btn.TabIndex)
                        {
                            conBtn.Location = new Point(0, conBtn.Location.Y + tvMenu.Size.Height);
                        }
                    }
                }
            }

            CheckBtnIndex = btn.TabIndex;
            tvMenu.Location = new Point(0, btn.Location.Y + btn.Size.Height);
            CreateMenuTree(btn.Text.Trim());
            open = true;
        }
        /// <summary>
        /// 메뉴선택시 메뉴하위목록 트리뷰로 생성
        /// </summary>
        /// <param name="btnname"></param>
        private void CreateMenuTree(string btnname)
        {


            try
            {
                if (menulist.Count > 0)
                {
                    MenuTree_Master_VO parentcode = menulist.Find(item => item.Screen_Name == btnname);//부모코드find
                    List<MenuTree_Master_VO> menu = menulist.FindAll(item => item.Parent_Screen_Code == parentcode.Screen_Code);//부모코드랑관련자녀메뉴
                    tvMenu.Nodes.Clear();
                    tvMenu.Nodes.Add(parentcode.Screen_Name);

                    for (int i = 0; i < menu.Count; i++)
                    {
                        tvMenu.TopNode.Nodes.Add(menu[i].Screen_Name);
                    }
                    tvMenu.ExpandAll();
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.ToString());
            }

        }
        #region 트리뷰관련 이벤트
        private void TvMenu_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (tvMenu.SelectedNode.Text != null)
                {
                    MenuTree_Master_VO parentcode = menulist.Find(item => item.Screen_Name == tvMenu.SelectedNode.Text);
                
                    if (parentcode.Parent_Screen_Code != null) //부모코드에 널값이있는 메뉴를 제외하고
                    {
                        string form = parentcode.Screen_Code;
                        newForm(form, tvMenu.SelectedNode.Text);

                        //sdfasd
                    }
                }
            }
            catch
            {


            }
        }
        /// <summary>
        /// 새로운 폼 생성
        /// </summary>
        /// <param name="formName">폼이름</param>
        private void newForm(string formName, string formText)
        {
            try
            {
                if (userinfoScreenItem.Count(item => item.Screen_Code == formName.ToString())>0) {



                    string nameSpace = "Axxen"; //네임스페이스 명
                Assembly cuasm = Assembly.GetExecutingAssembly();
                //string Format 의 따옴표와 마침표 주의!!
                string childFormName = string.Format("{0}.{1}", nameSpace, formName);
                Form frm = (Form)cuasm.CreateInstance(childFormName);

                foreach (Form childForm in Application.OpenForms)
                {
                    if (childForm.Tag.ToString().Equals(formName))
                    {
                        childForm.Activate();
                        return;
                    }
                }
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Tag = formName;
                TabPage newTab = new TabPage();
                newTab.Tag = formName;
                newTab.Text = formText;
                tabControl2.TabPages.Add(newTab);
             

                //    tabControl2.TabPages     .Tag=formName;
                //    MessageBox.Show(tabControl2.SelectedTab.Tag.ToString());
                frm.Show();
                    lblSubtitle.Text =  screenitemlist.Find(item => item.Screen_Code == formName.ToString()).Screen_Path.ToString();
                }
                else
                {
                    MessageBox.Show("사용권한이 없는 메뉴입니다." + formName);
                }
            }
            catch
            {
                MessageBox.Show("사용할 수 없는 메뉴" + formName);
            }
        }

        /// <summary>
        /// 메뉴클릭시 폼생성
        /// </summary>
        /// <typeparam name="T">where T : Form, new()</typeparam>
        public static void FormOpen<T>(Form MdiParent) where T : Form, new()
        {
            foreach (Form childForm in Application.OpenForms)
            {
                if (childForm is T)
                {
                    childForm.Activate();
                    return;
                }
            }
            T myform = new T();
            myform.MdiParent = MdiParent;
            myform.WindowState = FormWindowState.Maximized;
            myform.Show();
        }
        #endregion
        #region 즐겨찾기
        /// <summary>
        /// 즐겨찾기 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBookmark_Click(object sender, EventArgs e)
        {
            if (BookmarkCheck)
            {

                pnBookmark.Visible = true;
                BookmarkCheck = false;
                tvBookMark.Nodes.Clear();
                tvBookMark.Nodes.Add("즐겨찾기");

                for (int i = 0; i < booklist.Count; i++)
                {
                    tvBookMark.TopNode.Nodes.Add(booklist[i].Screen_Code);
                }

                tvBookMark.ExpandAll();
            }
            else
            {
                pnBookmark.Visible = false;
                BookmarkCheck = true;
            }

        }

        private void 즐겨찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MainForm_Service service = new MainForm_Service();
            MenuTree_Master_VO parentname = menulist.Find(item => item.Screen_Name == tvMenu.SelectedNode.Text);//부모코드find
            BookMark_VO bookmark = new BookMark_VO();
            bookmark.Parent_Screen_Code = parentname.Parent_Screen_Code;
            bookmark.Screen_Code = parentname.Screen_Code;
            bookmark.User_ID = UserInfo.User_ID;



            if (!service.InsertBookMark(bookmark))
            {
                MessageBox.Show("이미등록된 항목입니다.");
            }
            else
            {

                tvBookMark.Nodes.Clear();
                booklist = service.GetAll_BookMark(UserInfo.User_ID);
                tvBookMark.Nodes.Add("즐겨찾기");

                for (int i = 0; i < booklist.Count; i++)
                {
                    tvBookMark.TopNode.Nodes.Add(booklist[i].Screen_Code);
                }

                tvBookMark.ExpandAll();
            }




        }
        #endregion


        #region tabControl
        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabRect = this.tabControl2.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - CloseImage.Width,
                                         tabRect.Top + (tabRect.Height - CloseImage.Height) / 2,
                                         CloseImage.Width,
                                         CloseImage.Height);

                var sf = new StringFormat(StringFormat.GenericDefault);
                if (this.tabControl2.RightToLeft == System.Windows.Forms.RightToLeft.Yes &&
                    this.tabControl2.RightToLeftLayout == true)
                {
                    tabRect = GetRTLCoordinates(this.tabControl2.ClientRectangle, tabRect);
                    imageRect = GetRTLCoordinates(this.tabControl2.ClientRectangle, imageRect);
                    sf.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
                }

                e.Graphics.FillRectangle(Brushes.Aquamarine, e.Bounds); //텝페이지 색
                e.Graphics.DrawString(this.tabControl2.TabPages[e.Index].Text,
                                      this.Font, Brushes.Black, tabRect, sf);//텝페이지 폰트랑 글자 색

                e.Graphics.DrawImage(CloseImage, imageRect.Location); //텝페이지 취소이미지 생성

            }
            catch (Exception) { }
        }



        public static Rectangle GetRTLCoordinates(Rectangle container, Rectangle drawRectangle)
        {
            return new Rectangle(
                container.Width - drawRectangle.Width - drawRectangle.X,
                drawRectangle.Y,
                drawRectangle.Width,
                drawRectangle.Height);
        }


        private void TabControl2_MouseClick(object sender, MouseEventArgs e)
        {

            for (int i = 0; i < this.tabControl2.TabPages.Count; i++)
            {
                var tabRect = this.tabControl2.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - CloseImage.Width,
                                         tabRect.Top + (tabRect.Height - CloseImage.Height) / 2,
                                         CloseImage.Width,
                                         CloseImage.Height);


                if (imageRect.Contains(e.Location)) //x버튼 클릭시 폼종료
                {
                    foreach (Form childForm in Application.OpenForms)
                    {
                        if (childForm.Tag.ToString().Equals(tabControl2.SelectedTab.Tag.ToString()))
                        {
                            childForm.Close();
                            this.tabControl2.TabPages.RemoveAt(i);


                            break;
                        }

                    }
                }
                else //x버튼을 제제외한 텝페이지클릭시 폼 앞으로 && 튤박스에 해당 권한에 맞게 튤박스아이템 사용유무
                {
                    foreach (Form childForm in Application.OpenForms)
                    {
                        if (childForm.Tag.ToString().Equals(tabControl2.SelectedTab.Tag.ToString()))
                        {
                            ScreenItem_AuthorityVO screentype = new ScreenItem_AuthorityVO();
                            screentype =  userinfoScreenItem.Find(item => item.Screen_Code == tabControl2.SelectedTab.Tag.ToString());
                            if (screentype != null) {
                                if (screentype.Pre_Type[0] == 'Y')
                                {
                                    tsbInsert.Enabled = true;
                                }
                                else
                                {
                                    tsbInsert.Enabled = false;
                                }


                                if (screentype.Pre_Type[2] == 'Y')
                                {
                                    tsbtnUpdate.Enabled = true;
                                }
                                else
                                {
                                    tsbtnUpdate.Enabled = false;
                                }
                                if (screentype.Pre_Type[3] == 'Y')
                                {
                                    tsbtnDelete.Enabled = true;
                                }
                                else
                                {
                                    tsbtnDelete.Enabled = false;
                                }
                            }
                            childForm.Activate();
                            lblSubtitle.Text = screenitemlist.Find(item => item.Screen_Code == tabControl2.SelectedTab.Tag.ToString()).Screen_Path.ToString();

                            break;
                        }
                    }
                }

            }
        }
        /// <summary>
        /// 씨발
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 전체닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form children in this.MdiChildren)
            {
                children.Close();
            }

            tabControl2.TabPages.Clear();
        }

        #endregion


        /// <summary>
        /// 텝컨트롤의 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsbInsert_Click(object sender, EventArgs e)
        {
            if (this.InsertFormEvent != null)
                InsertFormEvent(this, null);
        }

        private void TsbtnRefresh_Click(object sender, EventArgs e)
        {
            if (this.RefreshFormEvent != null)
                RefreshFormEvent(this, null);
        }
    
        private void TsbtnUpdate_Click_1(object sender, EventArgs e)
        {
            if (this.MyUpdateEvent != null)
                MyUpdateEvent(this, null);
        }
    }
}
