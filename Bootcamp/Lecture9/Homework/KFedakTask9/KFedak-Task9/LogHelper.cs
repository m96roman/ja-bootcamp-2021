using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_Task9
{
    public class LogHelper : ApplicationException
    {
        public static string CreateExceptionString(Exception e)
        {
            StringBuilder sb = new StringBuilder();
            CreateExceptionString(sb, e);

            return sb.ToString();
        }

        private static void CreateExceptionString(StringBuilder sb, Exception e)
        {
            sb.AppendFormat($"{DateTime.Now.ToString("T")}");
            sb.AppendFormat("\n{0}Message:", e.Message);
            sb.AppendFormat("\n{0}Source:", e.Source);
            sb.AppendFormat("\n{0}Stacktrace:", e.StackTrace);
        }
    }
}
