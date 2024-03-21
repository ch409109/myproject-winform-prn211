using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Project_PRN211.DAO
{
    public class AdminDAO
    {
        private static AdminDAO instance;

        public static AdminDAO Instance 
        { 
            get
            {
                if(instance == null)
                {
                    instance = new AdminDAO();
                }
                return instance;
            }
            private set => instance = value; 
        }

        private AdminDAO() { }

        public bool Login(string username, string password)
        {
            return false;
        }
    }
}
