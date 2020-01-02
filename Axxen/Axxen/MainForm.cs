using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axxen
{
    public partial class MainForm : FreeForm
    {
        int CheckBtnIndex = 6;
        public MainForm()
        {
            InitializeComponent();
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
            #endregion
            Button btn = (Button)sender;
           
            foreach (var item in panelMenu.Controls)
            {
                Button conBtn;
                if (item is Button)
                {
                    conBtn = (Button)item;
                    if (btn.TabIndex < CheckBtnIndex)
                    {
                        if (btn.TabIndex < conBtn.TabIndex && CheckBtnIndex >= conBtn.TabIndex)
                        {
                            conBtn.Location = new Point(0, conBtn.Location.Y + 404);
                        }
                    }

                    if (conBtn.TabIndex <= btn.TabIndex)
                    {
                        if (conBtn.TabIndex > CheckBtnIndex)
                        {
                            conBtn.Location = new Point(0, conBtn.Location.Y - 404);
                        }
                    }
                }
            }
            CheckBtnIndex = btn.TabIndex;
            tvMenu.Location = new Point(0, btn.Location.Y + 33);
        }

        /// <summary>
        /// 메뉴선택시 해당 메뉴의 자식을 트리뷰로 보여준다.
        /// </summary>
        public static void TreeViewShow()
        {

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
    }
}
