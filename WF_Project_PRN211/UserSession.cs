using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Project_PRN211.DataAccess;

namespace WF_Project_PRN211
{
    public static class UserSession
    {
        public static Admin CurrentUser { get; set; }
    }
}
