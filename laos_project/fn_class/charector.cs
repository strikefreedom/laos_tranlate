using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laos_project.fn_class
{
    
    public class charector
    {
        private static string []x0 = new string[5];
        private static string []x1 = new string[1];
        private static string []x = new string[29];
        private static string []x2 = new string[4];
        private static string []x3 = new string[2];
        private static string []x4 = new string[7];
        private static string []x5 = new string[4];
        private static string []x6 = new string[3];
        private static string []x7 = new string[3];
        private static string []x8 = new string[8];
        private static string []x9 = new string[6];
        private static string []x10 = new string[3];


        public static bool check_char(string data)
        {
            setx();
            bool ret = false;
            for (int i=0; i < x.Length; i++)
            {
                if (data.Equals(x[i])) ret = true;
            }
                return ret;
        }
        public static bool check_vowel(string data)
        {
            setx0();
            setx3();
            setx4();
            setx7();
            bool ret = false;
            for (int i = 0; i < x0.Length; i++)
            {
                if (data.Equals(x0[i])) ret = true;
            }
            for (int i = 0; i < x3.Length; i++)
            {
                if (data.Equals(x3[i])) ret = true;
            }
            for (int i = 0; i < x4.Length; i++)
            {
                if (data.Equals(x4[i])) ret = true;
            }
            for (int i = 0; i < x7.Length; i++)
            {
                if (data.Equals(x7[i])) ret = true;
            }
            return ret;
        }
        public static void setx0()
        {
            x0[0]="ເ";
            x0[1] = "ແ";
            x0[2] = "ໂ";
            x0[3] = "ໄ";
            x0[4] = "ໃ";
        }
        public static void setx1()
        {
            x1[0]="ຫ";
        }
        public static void setx()
        {
            x[0] = "ກ";
            x[1] = "ຂ";
            x[2] = "ຄ";
            x[3] = "ງ";
            x[4] = "ຈ";
            x[5] = "ສ";
            x[6] = "ຊ";
            x[7] = "ຍ";
            x[8] = "ດ";
            x[9] = "ຕ";
            x[10] = "ຖ";
            x[11] = "ທ";
            x[12] = "ນ";
            x[13] = "ບ";
            x[14] = "ປ";
            x[15] = "ຜ";
            x[16] = "ຝ";
            x[17] = "ພ";
            x[18] = "ຟ";
            x[19] = "ມ";
            x[20] = "ຢ";
            x[21] = "ຣ";
            x[22] = "ລ";
            x[23] = "ວ";
            x[24] = "ຫ";
            x[25] = "ອ";
            x[26] = "ຮ";
            x[27] = "ໜ";
            x[28] = "ໝ";
        }
        public static void setx2()
        {
            x2[0] = "ຼ";
            x2[1] = "ຣ";
            x2[2] = "ວ";
            x2[3] = "ລ";
        }
        public static void setx3()
        {
            x3[0] = "ຸ";
            x3[1] = "ູ";
        }
        public static void setx4()
        {
            x4[0] = "ິ";
            x4[1] = "ີ";
            x4[2] = "ຶ";
            x4[3] = "ື";
            x4[4] = "ໍ";
            x4[5] = "ົ";
            x4[6] = "ັ";
        }
        public static void setx5()
        {
            x5[0] = "່";
            x5[1] = "້";
            x5[2] = "໊";
            x5[3] = "໋";
        }
        public static void setx6()
        {
            x6[0] = "ວ";
            x6[1] = "ອ";
            x6[2] = "ຽ";
        }
        public static void setx7()
        {
            x7[0] = "ະ";
            x7[1] = "າ";
            x7[2] = "ຳ";
        }
        public static void setx8()
        {
            x8[0] = "ກ";
            x8[1] = "ງ";
            x8[2] = "ຍ";
            x8[3] = "ດ";
            x8[4] = "ນ";
            x8[5] = "ມ";
            x8[6] = "ບ";
            x8[7] = "ວ";
        }
        public static void setx9()
        {
            x9[0] = "ຈ";
            x9[1] = "ສ";
            x9[2] = "ຊ";
            x9[3] = "ພ";
            x9[4] = "ຟ";
            x9[5] = "ລ";
        }
        public static void setx10()
        {
            x10[0] = "ຯ";
            x10[1] = "ໆ";
            x10[2] = "໌";
        }
    }
}