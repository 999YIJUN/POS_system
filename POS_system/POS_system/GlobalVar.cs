using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POS_system
{
    internal class GlobalVar
    {
        // DB connect
        public static string strMyDBConnectionString = string.Empty;

        public static bool isLoginSuccess = false;
        public static string strName = string.Empty;
        public static int intID = 0;
        public static int permission = 0;
       
        // path
        public static string image_dir = string.Empty;
    }
}
