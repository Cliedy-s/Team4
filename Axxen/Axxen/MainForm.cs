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
        int CheckBtnIndex = 7;
        bool BookmarkCheck = true; //즐겨찾기 
        int btntabindexCheck = -1; //현재 선택한버튼 채크
        bool btnCheck = true; //현재 선택한버튼 채크2
        bool open = true;


        Image CloseImage;

        List<MenuTree_Master_VO> menulist; //메뉴
        List<BookMark_VO> booklist;

        public MainForm()
        {
            InitializeComponent();

              ImageList imgList = new ImageList();
              imgList.Images.Add(Bitmap.FromFile("treeimg.png"));
              tvMenu.ImageList = imgList;
            MainForm_Service service = new MainForm_Service();
            menulist = service.GetAll_MenuTree_Master();


            //booklist = service.GetAll_BookMark(1);
            //lbxbookmark.DataSource = booklist;


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

            #region 좆망
            //   Button btn = (Button)sender;
            //int CheckBtnIndex=   btn.TabIndex;
            //    int count =100;
            //   bool check = false;
            //   bool check2 = false;
            //   foreach (var item in panelMenu.Controls)
            //   {
            //       Button allbtn;

            //       if (item is Button)
            //       {
            //           allbtn = (Button)item;
            //           if (((Button)allbtn).Text == btn.Text)
            //           {
            //               check = true;
            //               tvMenu.Location = new Point(0, btn.Location.Y + 33);                   
            //           }
            //           else if(check)
            //           {

            //               if (((Button)allbtn).Text != btn.Text)
            //               {
            //                   if (!check2)
            //                   {
            //                       allbtn.Location = new Point(0, tvMenu.Location.Y+200);
            //                       check2 = true;
            //                   }
            //                   else
            //                   {
            //                       allbtn.Location = new Point(0, allbtn.Location.Y );
            //                   }

            //               }
            //           }

            //       }
            //   }




            //Button btn = (Button)sender;
            //if (btn.TabIndex == btntabindexCheck) // 같은 메뉴 두번클릭시
            //{
            //    if (btnCheck)
            //    {
            //        tvMenu.Visible = true;
            //        btnCheck = false;
            //    }
            //    else
            //    {

            //        tvMenu.Visible = false;
            //        btnCheck = true;

            //    }
            //}
            //else //처음선택시
            //{
            //    btntabindexCheck = btn.TabIndex;
            //    tvMenu.Visible = true;
            //    btnCheck = false;
            //}


            //foreach (var item in panelMenu.Controls)
            //{
            //    Button conBtn;
            //   if(! btnCheck) { 
            //    if (item is Button)
            //    {
            //        conBtn = (Button)item;
            //        if (btn.TabIndex < CheckBtnIndex)
            //        {
            //            if (btn.TabIndex < conBtn.TabIndex && CheckBtnIndex >= conBtn.TabIndex)
            //            {
            //                conBtn.Location = new Point(0, conBtn.Location.Y + tvMenu.Size.Height);
            //            }
            //        }

            //        if (conBtn.TabIndex <= btn.TabIndex)
            //        {
            //            if (conBtn.TabIndex > CheckBtnIndex)
            //            {
            //                conBtn.Location = new Point(0, conBtn.Location.Y - tvMenu.Size.Height);
            //            }
            //        }
            //    }
            //    }
            //    else
            //    {                                     
            //            if (item is Button)
            //            {
            //                conBtn = (Button)item;
            //                if (conBtn.TabIndex > CheckBtnIndex)
            //                {
            //                    conBtn.Location = new Point(0, conBtn.Location.Y - tvMenu.Size.Height);
            //                }
            //            if (conBtn.TabIndex < CheckBtnIndex)
            //            {
            //                conBtn.Location = new Point(0, conBtn.Location.Y + tvMenu.Size.Height);
            //            }
            //        }

            //    }


            //}
            //CheckBtnIndex = btn.TabIndex;
            //tvMenu.Location = new Point(0, btn.Location.Y + 33);

            #endregion
            tvMenu.Visible = true;
            // 누르는 버튼
            Button btn = (Button)sender;
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

                MessageBox.Show(err.ToString() );
            }

        }
        #region 폼동적생성
        /// <summary>
        /// 트리뷰 자식메뉴클릭시 폼생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MenuTree_Master_VO parentcode = menulist.Find(item => item.Screen_Name == e.Node.Text);

            if (parentcode.Parent_Screen_Code != null) //부모코드에 널값이있는 메뉴를 제외하고
            {
                string form = parentcode.Screen_Code;
                newForm(form);
            }

        }
        /// <summary>
        /// 새로운 폼 생성
        /// </summary>
        /// <param name="formName">폼이름</param>
        private void newForm(string formName)
        {
            try
            {
                string nameSpace = "Axxen"; //네임스페이스 명
                Assembly cuasm = Assembly.GetExecutingAssembly();
                //string Format 의 따옴표와 마침표 주의!!
                Form frm = (Form)cuasm.CreateInstance(string.Format("{0}.{1}", nameSpace, formName));
             //   frm.MdiParent = this;
               // frm.WindowState = FormWindowState.Maximized;
               // frm.Show();
                frm.TopLevel = false;
                tabControl2.TabPages.Add((tabControl2.TabPages.Count + 1).ToString());
                tabControl2.TabPages[tabControl2.TabPages.Count - 1].Controls.Add(frm);
                tabControl2.SelectedIndex = tabControl2.TabPages.Count - 1;
                tabControl2.TabPages[tabControl2.TabPages.Count - 1].Text = frm.Text;
                frm.WindowState = FormWindowState.Maximized;
                frm.MdiParent = this;
                frm.Show();

            }
            catch (Exception err)
            {

                MessageBox.Show(err.ToString());
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
            }
            else
            {
                pnBookmark.Visible = false;
                BookmarkCheck = true;
            }

        }

        private void 즐겨찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tvMenu.SelectedNode.Text);
            //MainForm_Service service = new MainForm_Service();
            //MenuTree_Master_VO parentname = menulist.Find(item => item.Screen_Name == tvMenu.SelectedNode.Text.Trim());//부모코드find

            //if (booklist.Count < 1)
            //{
            //    service.InsertBookMark(parentname.Parent_Screen_Code, parentname.Screen_Code);
            //    return;
            //}

            //int a = booklist.Find(item => item.Screen_Code == parentname.Screen_Code).;
            //for (int i=0; i< booklist.Count; i++)
            //{
            //  if(  booklist[i].Screen_Code != parentname.Screen_Code)//등록된즐겨찾기가 아니라면.
            //    {
                  
            //        service.InsertBookMark(parentname.Parent_Screen_Code, parentname.Screen_Code);
            //        break;
            //    }
            //}


            //booklist = service.GetAll_BookMark(1);
            //lbxbookmark.DataSource = booklist;



        }
        #endregion

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

                e.Graphics.DrawString(this.tabControl2.TabPages[e.Index].Text,
                                      this.Font, Brushes.Black, tabRect, sf);
                e.Graphics.DrawImage(CloseImage, imageRect.Location);

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

        private void MainForm_Load(object sender, EventArgs e)
        {

            this.tabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            tabControl2.DrawItem += TabControl1_DrawItem;
            tabControl2.MouseClick += TabControl2_MouseClick;
            CloseImage =Image.FromFile("treeimg.png"); ;
            this.tabControl2.Padding = new Point(10, 3);
        }

        private void TabControl2_MouseClick(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.tabControl2.TabPages.Count; i++)
            {
                var tabRect = this.tabControl2.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - CloseImage.Width,
                                         tabRect.Top + (tabRect.Height - CloseImage.Height) / 2,
                                         CloseImage.Width,
                                         CloseImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    string nameSpace = "Axxen"; //네임스페이스 명
                    Assembly cuasm = Assembly.GetExecutingAssembly();
                    //string Format 의 따옴표와 마침표 주의!!
                    Form frm = (Form)cuasm.CreateInstance(string.Format("{0}.{1}", nameSpace, tabControl2.SelectedTab.Text));
                    frm.Close();
                    frm.Dispose();
                    
                    this.tabControl2.TabPages.RemoveAt(i);
                    
                    break;
                }
            }
        }
    }
}
