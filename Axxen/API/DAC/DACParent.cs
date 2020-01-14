
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Web.Configuration;
using System.Xml;

namespace API.DAC
{
    /// <summary>
    /// 부모 상속 받은 후 원하는 메소드만 재정의 ( 빈 줄 Alt+Enter 후 [재정의 생성...] 참조 )
    /// </summary>
    public abstract class DACParent
    {
        protected string Connstr
        {
            get
            {
                return WebConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            }
        }
    }
}
