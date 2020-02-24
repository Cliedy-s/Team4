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
using System.Runtime.InteropServices; //winapi 핫키
using System.Diagnostics;

namespace Axxen
{
    public partial class MainForm : Form
    {
        public event EventHandler InsertFormEvent; //추가 폼 이벤트
        public event EventHandler RefreshFormEvent; //새로고침 폼 이벤트
        public event EventHandler MyUpdateEvent; //수정 이벤트
        public event EventHandler MyDeleteEvent; //삭젱

        int CheckBtnIndex = 20;
        bool BookmarkCheck = true; //즐겨찾기 
        bool open = true;
        //  int SegCnt =0; //화면 사용이력 순번

        Form frm;

        Image CloseImage;
        UserGroupService UserGroupservice = new UserGroupService();
        List<MenuTree_Master_VO> menulist; //메뉴
        List<BookMark_VO> booklist;
        MainForm_Service Mainservice = new MainForm_Service();
        ScreenItemService screenservice = new ScreenItemService();
        UserInfo_Service userservice = new UserInfo_Service();
        List<UserGroup_MappingVO> userinfoGrouplist; //유저가속한 그룹
        List<ScreenItem_AuthorityVO> userinfoScreenItem;//그룹에속한 화면들
        List<ScreenItem_MasterVO> screenitemlist; //모든 스크린 

        List<Button> myButtons = new List<Button>();
        public MainForm()
        {
            InitializeComponent();

        }

        //[DllImport("user32.dll")]
        //public static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk);

        //[DllImport("user32.dll")]
        //public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        //const int HOTKEY_ID = 31197; //Any number to use to identify the hotkey instance

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        const int HOTKEY_ID = 31197; //Any number to use to identify the hotkey instance

        private class UserDante
        {
            public string Userkey { get; set; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tvMenu.Visible = false;
            toolStripButtoncencle.Alignment = ToolStripItemAlignment.Right; //즐겨찾기 툴스트립 버튼 오른쪽으로 배치
            toolStripButtonSetting.Alignment = ToolStripItemAlignment.Right; //세팅버튼
            toolStripButtonLogin.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator3.Alignment = ToolStripItemAlignment.Right;
        }
        private void ToolStripButtonLogin_Click(object sender, EventArgs e)
        {
            if (toolStripButtonLogin.Text.Equals("로그인"))
            {

                LoginForm frm = new LoginForm();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    toolStripButtonLogin.Text = "로그아웃";


                    List<UserDante> userDantelist = new List<UserDante>();
                    UserDante userdante1 = new UserDante();
                    UserDante userdante2 = new UserDante();
                    UserDante userdante3 = new UserDante();
                    UserDante userdante4 = new UserDante();

                    userdante1.Userkey = UserInfo.S01;
                    userDantelist.Add(userdante1);
                    userdante2.Userkey = UserInfo.S02;
                    userDantelist.Add(userdante2);
                    userdante3.Userkey = UserInfo.S03;
                    userDantelist.Add(userdante3);
                    userdante4.Userkey = UserInfo.S04;
                    userDantelist.Add(userdante4);

                    int firstkey = 0;
                    for (int i = 0; i < userDantelist.Count; i++)
                    {
                        string[] chuserkey = userDantelist[i].Userkey.Split('/');
                        if (chuserkey[0] == "Alt")
                        {
                            firstkey = 0x1;
                            RegisterHotKey(this.Handle, i, firstkey, Convert.ToChar(chuserkey[1]));
                        }
                        else if (chuserkey[0] == "Ctrl")
                        {
                            firstkey = 0x2;
                            RegisterHotKey(this.Handle, i, firstkey, Convert.ToChar(chuserkey[1]));
                        }
                        else if (chuserkey[0] == "Shift")
                        {
                            firstkey = 0x3;
                            RegisterHotKey(this.Handle, i, firstkey, Convert.ToChar(chuserkey[1]));
                        }
                        else
                        {
                            //  RegisterHotKey(this.Handle, i, 0x0, Convert.ToChar(chuserkey[1]));
                        }
                    }


                    lblLogin.Text = UserInfo.User_Name + " 님";


                    ImageList imgList = new ImageList();
                    //imgList.Images.Add(Bitmap.FromFile("treeimg.png"));
                    imgList.Images.Add(Properties.Resources.treeimg);
                    tvMenu.ImageList = imgList;
                    tvBookMark.ImageList = imgList;
                    this.tabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
                    CloseImage = Properties.Resources.x;
                    this.tabControl2.Padding = new Point(10, 3);
                    UserInformation();
                    Setting();
                    booklist = Mainservice.GetAll_BookMark(UserInfo.User_ID);

                    if (!UserInfo.Default_Screen_Code.Equals("0")) //사용자의 디폴트 화면 가져오기
                    {
                        newForm(UserInfo.Default_Screen_Code, screenitemlist.Find(item => item.Screen_Code == UserInfo.Default_Screen_Code).Type);
                    }
                }
                else
                {
                    frm.Close();
                }
            }
            else //로그아웃
            {
                if (MessageBox.Show("로그아웃을 정말 하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
        public void Setting()
        {
            // myButtons.Clear();
            foreach (Control item in panelMenu.Controls)
            {
                if (item is Button)
                {
                    if (!item.Name.Equals("메뉴"))
                        panelMenu.Controls.Remove(item);
                }
            }
            //panelMenu.Update();
            //panelMenu.Invalidate();
            //this.Invalidate();

            menulist = Mainservice.GetAll_MenuTree_Master();

            var pa = menulist.FindAll(item => item.Parent_Screen_Code == null);
            int sLocation = 0;

            for (int i = 0; i < pa.Count; i++)
            {
                Button menuBtn = new Button();
                menuBtn.BackColor = System.Drawing.Color.White;
                menuBtn.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                menuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                menuBtn.Location = new System.Drawing.Point(3, 45 + sLocation);
                menuBtn.Margin = new System.Windows.Forms.Padding(5);
                menuBtn.Name = pa[i].Screen_Code;
                menuBtn.Size = new System.Drawing.Size(261, 37);
                menuBtn.TabIndex = i;
                menuBtn.Text = pa[i].Screen_Name;
                menuBtn.UseVisualStyleBackColor = false;
                menuBtn.Click += new EventHandler(BtnMenu_Click);
                // myButtons.Add(menuBtn);
                // 생성한 버튼을 화면 컨트롤에 추가해서 보이게 함
                panelMenu.Controls.Add(menuBtn);
                sLocation += 35;
            }

            panelMenu.Update();
            panelMenu.Invalidate();
            this.Refresh();
            this.Invalidate();
        }
        public void UserInformation()
        {
            userinfoGrouplist = UserGroupservice.GetUserInfoGroup(UserInfo.User_ID); //로그인한 사용자의 그룹권한들
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
                        //
                        // 열려있는 버튼과 현재 누른 사이의 버튼들의 위치 재조정
                        if (conBtn.TabIndex <= btn.TabIndex && conBtn.TabIndex > CheckBtnIndex)
                        {
                            conBtn.Location = new Point(0, conBtn.Location.Y - tvMenu.Size.Height);
                            //if (conBtn.TabIndex > CheckBtnIndex)
                            //{
                            //    conBtn.Location = new Point(0, conBtn.Location.Y - trvMenu.Size.Height);
                            //}
                            conBtn.BackColor = Color.White;
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
                            conBtn.BackColor = Color.White;
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
                        string form = parentcode.Screen_Code.Trim();
                        newForm(form, tvMenu.SelectedNode.Text.Trim());

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
        public void newForm(string formName, string formText)
        {
            try
            {
                if (userinfoScreenItem.Count(item => item.Screen_Code.Trim().Equals(formName.Trim())) > 0)
                {



                    string nameSpace = "Axxen"; //네임스페이스 명
                    Assembly cuasm = Assembly.GetExecutingAssembly();
                    //string Format 의 따옴표와 마침표 주의!!
                    string childFormName = string.Format("{0}.{1}", nameSpace, formName);
                    frm = (Form)cuasm.CreateInstance(childFormName);

                    foreach (Form childForm in Application.OpenForms)
                    {
                        if (childForm.Tag.ToString().Trim().Equals(formName.Trim()))
                        {


                            ScreenItem_AuthorityVO screentype = new ScreenItem_AuthorityVO();
                            screentype = userinfoScreenItem.Find(item => item.Screen_Code == formName.Trim());
                            if (screentype != null)
                            {
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



                            for (int i = 0; i < tabControl2.TabPages.Count; i++) //활성화된 메뉴의 탭페이지눌릴수 있도록
                            {
                                if (tabControl2.TabPages[i].Tag.Equals(formName))
                                {

                                    tabControl2.SelectedIndex = i;
                                    break;
                                }

                            }
              
                            childForm.Activate();
                       
                            return;
                        }
                    }
          
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.SizeChanged += Frm_SizeChanged;
                    //frm.Text = "";
                    frm.Tag = formName;
                    TabPage newTab = new TabPage();
                    newTab.Tag = formName;
                    newTab.Text = formText;

                    tabControl2.TabPages.Add(newTab);

                    tabControl2.SelectedTab = newTab; //새로연 메뉴의 화면 텝페이지 눌릴 수 있도록
                    frm.Show();
              
                    /////////////////// 메뉴클릭시 
                    foreach (Form childForm in Application.OpenForms)
                    {
                        ScreenItem_AuthorityVO screentype = new ScreenItem_AuthorityVO();
                        screentype = userinfoScreenItem.Find(item => item.Screen_Code == formName.Trim());
                        if (screentype != null)
                        {
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

                            break;
                        }
                    }
                    //////////////////////////////////////////

                    //  tabControl2.TabPages.Tag=formName;
                    //  MessageBox.Show(tabControl2.SelectedTab.Tag.ToString());
                    //  SegCnt++;
                    Login_Screen_HistoryVO loginscreen = new Login_Screen_HistoryVO()
                    {
                        Session_ID = UserInfo.Session_ID,
                        //    Seg =SegCnt,
                        Open_Day = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                        Open_Date = DateTime.Now,
                        User_ID = UserInfo.User_ID,
                        Screen_Code = formName
                    };
                    userservice.InsertLogin_Screen_History(loginscreen);
                    lblSubtitle.Text = screenitemlist.Find(item => item.Screen_Code == formName.ToString()).Screen_Path.ToString();
                }
                else
                {
                    MessageBox.Show("사용권한이 없는 메뉴입니다." + formName);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("사용할 수 없는 메뉴" + err.Message + formName);
                throw;
            }
        }

        private void Frm_SizeChanged(object sender, EventArgs e)
        {
            if (frm.WindowState == FormWindowState.Maximized)
            { // checks Form's Window state and return true if it is maximized (mdi child's event btw)
                this.Text = "SPOK"; // do what ever do you want in here
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
            if (booklist != null)
            {
                if (BookmarkCheck)
                {

                    pnBookmark.Visible = true;
                    BookmarkCheck = false;
                    tvBookMark.Nodes.Clear();
                    tvBookMark.Nodes.Add("즐겨찾기");

                    for (int i = 0; i < booklist.Count; i++)
                    {
                        tvBookMark.TopNode.Nodes.Add(booklist[i].Type);
                    }

                    tvBookMark.ExpandAll();
                }
                else
                {
                    pnBookmark.Visible = false;
                    BookmarkCheck = true;
                }
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
            bookmark.Type = parentname.Screen_Name;

            if (!string.IsNullOrEmpty(parentname.Parent_Screen_Code))
            {

                if (!service.InsertBookMark(bookmark))
                {
                    MessageBox.Show("이미등록된 항목입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    tvBookMark.Nodes.Clear();
                    booklist = service.GetAll_BookMark(UserInfo.User_ID);
                    tvBookMark.Nodes.Add("즐겨찾기");

                    for (int i = 0; i < booklist.Count; i++)
                    {
                        tvBookMark.TopNode.Nodes.Add(booklist[i].Type);
                    }

                    tvBookMark.ExpandAll();
                }

            }
            else
            {
                MessageBox.Show("등록할 수 없는 항목입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ///  sf.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
                    sf.FormatFlags |= StringFormatFlags.DirectionVertical;
                }

                if (this.tabControl2.TabPages[e.Index] == tabControl2.SelectedTab)
                {

                    e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.Bounds); //텝페이지 색
                    //LightSkyBlue
                }
                else
                {
                    // e.Graphics.FillRectangle(Brushes.PaleTurquoise, e.Bounds); //텝페이지 색
                }


                e.Graphics.DrawString(this.tabControl2.TabPages[e.Index].Text,
                                      this.Font, Brushes.Black, tabRect, sf);//텝페이지 폰트랑 글자 색

                e.Graphics.DrawImage(CloseImage, imageRect.Location.X - 4, imageRect.Location.Y - 4); //텝페이지 취소이미지 생성



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
                            screentype = userinfoScreenItem.Find(item => item.Screen_Code == tabControl2.SelectedTab.Tag.ToString());
                            if (screentype != null)
                            {
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
                            //    tabControl2.SelectedTab. = Color.Red; //텝페이지 색
                            childForm.Activate();

                            lblSubtitle.Text = screenitemlist.Find(item => item.Screen_Code == tabControl2.SelectedTab.Tag.ToString()).Screen_Path.ToString();

                            break;
                        }
                    }
                }

            }
        }
        /// <summary>
        /// 
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
            try
            {
                if (this.InsertFormEvent != null)
                    InsertFormEvent(this, null);

            }
            catch (Exception err)
            {

                Program.Log.WriteError(err.Message);
            }
        }

        private void TsbtnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.RefreshFormEvent != null)
                    RefreshFormEvent(this, null);
            }
            catch (Exception err)
            {

                Program.Log.WriteError(err.Message);
            }
        }

        private void TsbtnUpdate_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (this.MyUpdateEvent != null)
                    MyUpdateEvent(this, null);
            }
            catch (Exception err)
            {

                Program.Log.WriteError(err.Message);
            }
        }

        private void TsbtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.MyDeleteEvent != null)
                    MyDeleteEvent(this, null);
            }
            catch (Exception err)
            {

                Program.Log.WriteError(err.Message);
            }

        }

        private void TvBookMark_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                if (tvBookMark.SelectedNode.Text != null)
                {
                    MenuTree_Master_VO parentcode = menulist.Find(item => item.Screen_Name == tvBookMark.SelectedNode.Text);

                    if (parentcode.Parent_Screen_Code != null) //부모코드에 널값이있는 메뉴를 제외하고
                    {
                        string form = parentcode.Screen_Code;
                        newForm(form, tvBookMark.SelectedNode.Text);

                    }
                }
            }
            catch
            {


            }
        }

        private void ToolStripButtoncencle_Click(object sender, EventArgs e)
        {
            pnBookmark.Visible = false;
        }

        private void ToolStripButtonSetting_Click(object sender, EventArgs e)
        {
            if (UserInfo.User_ID != null)
            {
                UserSettingForm frm = new UserSettingForm();
                frm.ShowDialog();
            }
        }



        private void Button9_Click(object sender, EventArgs e)
        {
            Setting();
            btnManuReflash.Text = "메뉴";
        }

        private void BtnManuReflash_Click(object sender, EventArgs e) //메뉴세로고침
        {
            if (UserInfo.User_ID != null)
            {
                Setting();
                Setting();
                Setting();

                btnManuReflash.Text = "메뉴";
            }

        }


        protected override void WndProc(ref Message message)
        {
            try
            {


                base.WndProc(ref message);


                if (message.Msg == (int)0x312) //핫키가 눌러지면 312 정수 메세지를 받게됨
                {
                    if (message.WParam == (IntPtr)0x0) // 0x0아이디 추가
                    {
                        tsbInsert.PerformClick();
                    }
                    else if (message.WParam == (IntPtr)0x1) // 수정
                    {
                        tsbtnUpdate.PerformClick();
                    }
                    else if (message.WParam == (IntPtr)0x2) // 삭제
                    {
                        tsbtnDelete.PerformClick();
                    }
                    else if (message.WParam == (IntPtr)0x3) //새로고침
                    {
                        tsbtnRefresh.PerformClick();
                    }
                }
            }
            catch (Exception err)
            {

                Program.Log.WriteError(err.Message);
            }


        }

        private void 메모장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void 계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void 그림판ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Process.Start("mspaint.exe");
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://team4webserver.azurewebsites.net/");
        }
    }
}
