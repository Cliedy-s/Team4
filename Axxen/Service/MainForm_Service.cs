﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAC;
using VO;
namespace Service
{
    public class MainForm_Service
    {
        public List<MenuTree_Master_VO> GetAll_MenuTree_Master()
        {
            MainForm_DAC dac = new DAC.MainForm_DAC();

            return dac.GetAll_MenuTree_Master();
        }
        public List<BookMark_VO> GetAll_BookMark(string id)
        {
            MainForm_DAC dac = new DAC.MainForm_DAC();

            return dac.GetAll_BookMark(id);
        }

        public bool InsertBookMark(BookMark_VO list)
        {
            MainForm_DAC dac = new DAC.MainForm_DAC();

            return dac.InsertBookMark(list);
        }
      }
}
