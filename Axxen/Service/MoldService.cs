﻿using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class MoldService
    {
        public List<MoldVO> SelectMoldAll()
        {
            MoldDAC dac = new MoldDAC();
            return dac.SelectMoldAll();
        }
    }
}