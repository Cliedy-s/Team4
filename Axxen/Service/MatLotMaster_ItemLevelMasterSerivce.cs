﻿using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class MatLotMaster_ItemLevelMasterSerivce
    {
        public List<MatLotMaster_ItemLevelMasterVO> GetAllMatLotMaster_ItemLevelMaster() // QAM_SQC_006 전체 조회
        {
            MatLotMaster_ItemLevelMasterDAC dac = new MatLotMaster_ItemLevelMasterDAC();
            return dac.GetAllMatLotMaster_ItemLevelMaster();
        }
    }
}
