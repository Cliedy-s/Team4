using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Emp_Allocation_HistoryService
	{
		/// <summary>
		/// 작업자 할당
		/// </summary>
		public bool InsertWorkerAllocate(string targetUserId, string username, string wcCode)
		{
			Emp_Allocation_HistoryDAC dac = new Emp_Allocation_HistoryDAC();
			return dac.InsertWorkerAllocate(targetUserId, username, wcCode);
		} 
		/// <summary>
		/// 작업자 해제
		/// </summary>
		/// <param name="targetUserId"></param>
		/// <param name="username"></param>
		/// <param name="wcCode"></param>
		/// <returns></returns>
		public bool UpdateWorkerDeallocate(string targetUserId, string username, string wcCode)
		{
			Emp_Allocation_HistoryDAC dac = new Emp_Allocation_HistoryDAC();
			return dac.UpdateWorkerDeallocate( targetUserId,  username,  wcCode);
		} 
	}
}
