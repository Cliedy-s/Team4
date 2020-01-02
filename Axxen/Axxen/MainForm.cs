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

namespace Axxen
{
    public partial class MainForm : Form
    {
        int CheckBtnIndex = 6;
        bool BookmarkCheck = true; //즐겨찾기 
        int btntabindexCheck = -1; //현재 선택한버튼 채크
        bool btnCheck = true; //현재 선택한버튼 채크2
        bool open = true;

        List<MenuTree_Master_VO> menulist;

        public MainForm()
        {
            InitializeComponent();

            ImageList imgList = new ImageList();
            imgList.Images.Add(Bitmap.FromFile("treeimg.png"));
            tvMenu.ImageList = imgList;
            // MainForm_Service service = new MainForm_Service();
            // menulist = service.GetAll_MenuTree_Master();
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

            if (menulist.Count > 0)
            {
                MenuTree_Master_VO parentcode = menulist.Find(item => item.Screen_Name == btnname);
                List<MenuTree_Master_VO> menu = menulist.FindAll(item => item.Parent_Screen_Code == parentcode.Screen_Code);

                tvMenu.Nodes.Clear();
                tvMenu.Nodes.Add(parentcode.Screen_Name);
              //  tvMenu.TopNode.
                for (int i = 0; i < menu.Count; i++)
                {
                    tvMenu.TopNode.Nodes.Add(menu[i].Screen_Name);
                }
            }

        }
        private void TvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MenuTree_Master_VO parentcode = menulist.Find(item => item.Screen_Name == e.Node.Text);

            if(parentcode.Parent_Screen_Code != null) { 
            string form = parentcode.Screen_Code;
            newForm(form);
            }

        }
        private void newForm(string formName)
        {
            try
            {

           
            string nameSpace = "Axxen"; //네임스페이스 명
            Assembly cuasm = Assembly.GetExecutingAssembly();
            //string Format 의 따옴표와 마침표 주의!!
            Form frm = (Form)cuasm.CreateInstance(string.Format("{0}.{1}", nameSpace, formName));
            frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("없는 폼");
            }
        }

        /// <summary>
        /// 
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

        /// <summary>
        /// 즐겨찾기
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

        }
    }
}
