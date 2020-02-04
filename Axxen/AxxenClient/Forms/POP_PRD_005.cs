﻿using Axxen.CustomControls;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using VO;

namespace AxxenClient.Forms
{
    public partial class POP_PRD_005 : AxxenClient.Templets.ClientBaseForm
    {
        int palletqty;
        int palletQty { 
            get { return palletqty; }
            set {
                palletqty = value;
                txtPalletQty.TextBoxText = palletqty.ToString();
            } 
        }
        public POP_PRD_005()
        {
            InitializeComponent();
        }
        private void POP_PRD_005_Load(object sender, EventArgs e)
        {
            InitControls();
            GetDatas();
        }
        private void InitControls()
        {
            InitControlUtil.SetPOPDGVDesign(dgvInPallet);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "작업지시번호", "WorkOrderNo", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "팔레트번호", "Pallet_No", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "제품", "Item_Name", true);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "등급", "Boxing_Grade_Code", true, 100, DataGridViewContentAlignment.MiddleCenter);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "수량", "CurrentQty", true, 100, DataGridViewContentAlignment.MiddleRight);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "등급상세", "Grade_Detail_Code", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "사이즈", "Size_Code", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "계획날짜", "Plan_Date", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "제품", "Item_Code", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "작업장코드", "Wc_Code", false);
        }
        private void GetDatas()
        {
            Pallet_MasterService service = new Pallet_MasterService();
            dgvInPallet.DataSource = service.GetPalletTodayIn();
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            Pallet_MasterService service = new Pallet_MasterService();
            if (!service.IsExistPallet(txtPalletNo.TextBoxText))
            {
                MessageBox.Show("팔레트 번호를 확인해주세요");
                return;
            }
            bool isSuccess = service.InputPallet(GlobalUsage.UserID, GlobalUsage.WorkOrderNo, txtPalletNo.TextBoxText);
            if (!isSuccess)
            {
                MessageBox.Show("입고에 실패하였습니다.");
                return;
            }
            GetDatas();
            lblBarcodeNo.Text = "";

        }
        private void txtPalletNo_searchclick(object sender, EventArgs e)
        {
            Pallet_MasterService service = new Pallet_MasterService();
            PalletTodayInVO item = service.GetPalletInfo(txtPalletNo.TextBoxText);

            txtPalletNo.TextBoxText = item.Pallet_No;
            txtSize.TextBoxText = item.Plan_Date.ToString("yyyy-MM-dd HH:mm:ss");
            txtBoxingGradeDatail.TextBoxText = item.Wc_Code;
            txtBoxingGrade.TextBoxText = item.Boxing_Grade_Code;
            txtPalletQty.TextBoxText = 0.ToString();
        }


        #region Serial Ports
        // 시리얼 포트
        private SerialPort _Port;
        /// <summary>
        /// 시리얼포트 컨트롤 객체
        /// </summary>
        private SerialPort Port
        {
            get
            {
                if (_Port == null)
                {
                    _Port = new SerialPort();
                    _Port.PortName = "COM5";
                    _Port.BaudRate = 9600;
                    _Port.DataBits = 8;
                    _Port.Parity = Parity.None;
                    _Port.Handshake = Handshake.None;
                    _Port.StopBits = StopBits.One;
                    _Port.Encoding = Encoding.UTF8;
                    _Port.DataReceived += Port_DataReceived;
                }
                return _Port;
            }
        }
        /// <summary>
        /// 시리얼포트 상태 및 컨트롤 제어
        /// </summary>
        private Boolean IsOpen
        {
            get { return Port.IsOpen; }
            set
            {
                if (value)
                {
                }
                else
                {
                }
            }
        }
        /// <summary>
        /// SerialPort : Data Received Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);
            String msg = Port.ReadExisting();

            this.Invoke(new EventHandler(delegate
            {
                Strings = msg;
            }));
        }

        /* 입력값 설정 */
        private StringBuilder _Strings;
        /// <summary>
        /// 로그 객체
        /// </summary>
        private String Strings
        {
            set
            {
                _Strings = null;
                if (_Strings == null)
                    _Strings = new StringBuilder(1024);
                // 로그 길이가 1024자가 되면 이전 로그 삭제
                if (_Strings.Length >= (1024 - value.Length))
                    _Strings.Clear();
                // 로그 추가 및 화면 표시
                _Strings.AppendLine(value);
                beforecode = lblBarcodeNo.Text;
                lblBarcodeNo.Text = "";
                lblBarcodeNo.Text = _Strings.ToString().Replace("+", "").Replace("\n","").Replace("\r","");
            }
        }
        #endregion

        private void SerialPortConnect()
        {
            if (!Port.IsOpen)
            {
                // 현재 시리얼이 연결된 상태가 아니면 연결.
                Port.PortName = "COM5";
                Port.BaudRate = 9600;
                Port.DataBits = 8;
                Port.Parity = Parity.None;
                Port.Handshake = Handshake.None;

                try
                {
                    // 연결
                    Port.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("[ERR] {0}", ex.Message);
                }
            }
            else
            {
                // 현재 시리얼이 연결 상태이면 연결 해제
                // Port.Close();
            }

            // 상태 변경
            IsOpen = Port.IsOpen;
        }
        private void POP_PRD_005_Activated(object sender, EventArgs e)
        {
            SerialPortConnect();
        }
        private void POP_PRD_005_Deactivate(object sender, EventArgs e)
        {

            // Port.Close();
        }

        string beforecode { get; set; }
        private void lblBarcodeNo_TextChanged(object sender, EventArgs e)
        {
            if(lblBarcodeNo.Text.Length >= 8) //TODO - 20으로 변경
            {
                Pallet_MasterService service = new Pallet_MasterService();
                PalletVO item = service.GetPalletByBarcode(lblBarcodeNo.Text);

                txtPalletNo.TextBoxText = item.Pallet_No;
                txtBoxingGrade.TextBoxText = item.Boxing_Grade_Code;
                txtBoxingGradeDatail.TextBoxText = item.Grade_Detail_Name;
                txtSize.TextBoxText = item.Size_Code;
                if (beforecode.Equals(lblBarcodeNo.Text))
                {
                    palletQty++;
                }
                else
                {
                    palletQty = 1;
                }
            }
        }
    }
}
