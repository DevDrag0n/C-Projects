using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class BL_PageContent
    {
        public static string VarOutput { get; set; }

        public static string CreatedBy { get; set; }

        public static void Course1()
        {
            //string VarOutput = null;

            string[] names = new string[3] { "COP3488C", "UWP2", "This course is mobile app development #2." };
            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "  ";
            }

        }




    }
}
