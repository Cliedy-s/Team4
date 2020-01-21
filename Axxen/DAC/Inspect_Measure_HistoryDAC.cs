using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAC
{
    class Inspect_Measure_HistoryDAC : DACParent
    {
        public List<InspectHistoryVO> GetAll()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = " SELECT "
                                                +   "  imh,Inspect_measure_seq   "
	                                            +   " , imh,Item_code                "
	                                            +   " , imh,Process_code            "
	                                            +   " , imh,Inspect_code            "
	                                            +   " , imh,Inspect_date             "
	                                            +   " , imh,Inspect_datetime       "
	                                            +   " , imh,Inspect_val               "
	                                            +   " , imh,Workorderno            "
                                                +   " FROM Inspect_Measure_History AS imh; ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<InspectHistoryVO> list = Helper.DataReaderMapToList<InspectHistoryVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        public bool InsertInspect_Measure(InspectHistoryVO item)
        { //TODO : 작성
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
				comm.CommandText = " INSERT INTO Inspect_Measure_History( "
						+ "	Inspect_measure_seq, Item_code, Process_code, Inspect_code, Inspect_date, Inspect_datetime "
						+ "	, Inspect_val	, Workorderno, Ins_Date	, Ins_Emp, Up_Date, Up_Emp) "
						+ "	VALUES(	@Inspect_measure_seq, @Item_code, @Process_code, @Inspect_code, @Inspect_date "
						+ "	, @Inspect_datetime, @Inspect_val, @Workorderno, @Ins_Date, @Ins_Emp, @Up_Date "
						+ "	, @Up_Emp);  ";

				comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                comm.Connection.Close();

                return false;
            }
        }
    }
}
