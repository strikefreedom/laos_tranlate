using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace laos_project.fn_class
{
    public class cutword
    {
        private static string[] laosChar = new string[34];
        private static string[] charFirst = new string[34];
        private static string[] charLast = new string[34];
        private static string[] carSound = new string[34];

        private static string[] vowel = new string[41];
        private static string[] voSat = new string[41];
        private static string[] voSound = new string[41];

        private static string[] x0 = new string[4];

        static string first;
        static int index=0;
        public static ArrayList main(string input)
        {
            inputdatachar();
            inputdatavol();
            first = input;
            ArrayList ret = new ArrayList();
            while (true)
            {
                if (!first.Equals("")) ret.Add(cut());
                else break;
            }
            return ret;
        }
        private static ArrayList cut()
        {
            index = 0;
            ArrayList ret = new ArrayList();
            
            try
            {
                first = first.Substring(index);
            }
            catch
            {
                first = "";
            }
            return ret;
        }
        private static bool checkchar(string str)
        {
            bool ret = false;
            for (int i = 0; i < 34; i++)
            {
                if (str.Equals(laosChar[i])) ret = true;
            }
            return ret;
        }




        private static void inputdatachar()
        {
            laosChar[0] = "ກ"; charFirst[0] = "k"; charLast[0] = "k"; carSound[0] = "2";
            laosChar[1] = "ຂ"; charFirst[1] = "kh"; charLast[1] = "k"; carSound[1] = "3";
            laosChar[2] = "ຄ"; charFirst[2] = "kh"; charLast[2] = "k"; carSound[2] = "1";
            laosChar[3] = "ງ"; charFirst[3] = "ng"; charLast[3] = "ng"; carSound[3] = "1";
            laosChar[4] = "ຈ"; charFirst[4] = "ch"; charLast[4] = "t"; carSound[4] = "2";
            laosChar[5] = "ສ"; charFirst[5] = "s"; charLast[5] = "t"; carSound[5] = "3";
            laosChar[6] = "ຊ"; charFirst[6] = "s"; charLast[6] = "t"; carSound[6] = "1";
            laosChar[7] = "ຍ"; charFirst[7] = "y"; charLast[7] = ""; carSound[7] = "1";
            laosChar[8] = "ດ"; charFirst[8] = "d"; charLast[8] = "t"; carSound[8] = "2";
            laosChar[9] = "ຕ"; charFirst[9] = "t"; charLast[9] = "t"; carSound[9] = "2";
            laosChar[10] = "ຖ"; charFirst[10] = "th"; charLast[10] = "t"; carSound[10] = "3";
            laosChar[11] = "ທ"; charFirst[11] = "th"; charLast[11] = "t"; carSound[11] = "1";
            laosChar[12] = "ນ"; charFirst[12] = "n"; charLast[12] = "ne/n"; carSound[12] = "1";
            laosChar[13] = "ບ"; charFirst[13] = "b"; charLast[13] = "p"; carSound[13] = "2";
            laosChar[14] = "ປ"; charFirst[14] = "p"; charLast[14] = "p"; carSound[14] = "2";
            laosChar[15] = "ຜ"; charFirst[15] = "ph"; charLast[15] = ""; carSound[15] = "3";
            laosChar[16] = "ຝ"; charFirst[16] = "f"; charLast[16] = "p"; carSound[16] = "3";
            laosChar[17] = "ພ"; charFirst[17] = "ph"; charLast[17] = "p"; carSound[17] = "1";
            laosChar[18] = "ຟ"; charFirst[18] = "f"; charLast[18] = "p"; carSound[18] = "1";
            laosChar[19] = "ມ"; charFirst[19] = "m"; charLast[19] = "m"; carSound[19] = "1";
            laosChar[20] = "ຢ"; charFirst[20] = "y"; charLast[20] = ""; carSound[20] = "2";
            laosChar[21] = "ຣ"; charFirst[21] = "r"; charLast[21] = "n"; carSound[21] = "1";
            laosChar[22] = "ລ"; charFirst[22] = "l"; charLast[22] = "n"; carSound[22] = "1";
            laosChar[23] = "ວ"; charFirst[23] = "w"; charLast[23] = ""; carSound[23] = "1";
            laosChar[24] = "ຫ"; charFirst[24] = "h"; charLast[24] = ""; carSound[24] = "3";
            laosChar[25] = "ອ"; charFirst[25] = ""; charLast[25] = ""; carSound[25] = "2";
            laosChar[26] = "ຮ"; charFirst[26] = "h"; charLast[26] = ""; carSound[26] = "1";
            laosChar[27] = "ຫຼ"; charFirst[27] = "l"; charLast[27] = ""; carSound[27] = "1";
            laosChar[28] = "ໝ"; charFirst[28] = "m"; charLast[28] = ""; carSound[28] = "1";
            laosChar[29] = "ໜ"; charFirst[29] = "n"; charLast[29] = ""; carSound[29] = "1";
            laosChar[30] = "ຫງ"; charFirst[30] = "ng"; charLast[30] = ""; carSound[30] = "1";
            laosChar[31] = "ຫຍ"; charFirst[31] = "y"; charLast[31] = ""; carSound[31] = "1";
            laosChar[32] = "ຫວ"; charFirst[32] = "w"; charLast[32] = ""; carSound[32] = "1";
            laosChar[33] = "ຫຣ"; charFirst[33] = "r"; charLast[33] = ""; carSound[33] = "1";

        }
        private static void inputdatavol()
        {
            vowel[0] = "ະ"; voSat[0] = "a"; voSound[0] = "1";
            vowel[1] = "ັ"; voSat[1] = "a"; voSound[1] = "1";
            vowel[2] = "ິ"; voSat[2] = "i"; voSound[2] = "1";
            vowel[3] = "ຶ"; voSat[3] = "ue"; voSound[3] = "1";
            vowel[4] = "ຸ"; voSat[4] = "ou"; voSound[4] = "1";
            vowel[5] = "ເ-ະ"; voSat[5] = "e"; voSound[5] = "1";
            vowel[6] = "ເ-ັ"; voSat[6] = "e"; voSound[6] = "1";
            vowel[7] = "ແ-ະ"; voSat[7] = "ae"; voSound[7] = "1";
            vowel[8] = "ແ-ັ"; voSat[8] = "ae"; voSound[8] = "1";
            vowel[9] = "ໂ-ະ"; voSat[9] = "o"; voSound[9] = "1";
            vowel[10] = "ົ"; voSat[10] = "o"; voSound[10] = "1";
            vowel[11] = "ເ-າະ"; voSat[11] = "o"; voSound[11] = "1";
            vowel[12] = "ັອ"; voSat[12] = "o"; voSound[12] = "1";
            vowel[13] = "ເ-ິ"; voSat[13] = "eu"; voSound[13] = "1";
            vowel[14] = "ເ-ັຍ"; voSat[14] = "ia"; voSound[14] = "1";
            vowel[15] = "ັຽ"; voSat[15] = "ia"; voSound[15] = "1";
            vowel[16] = "ເ"; voSat[16] = "ua"; voSound[16] = "1";
            vowel[17] = "ົວະ"; voSat[17] = "ua"; voSound[17] = "1";
            vowel[18] = "ັວ"; voSat[18] = "ua"; voSound[18] = "1";
            vowel[19] = "ໄ"; voSat[19] = "ai"; voSound[19] = "1";
            vowel[20] = "ໃ"; voSat[20] = "ai"; voSound[20] = "1";
            vowel[21] = "ັຍ"; voSat[21] = "ai"; voSound[21] = "1";
            vowel[22] = "ເ-ົາ"; voSat[22] = "ao"; voSound[22] = "1";
            vowel[23] = "ຳ"; voSat[23] = "am"; voSound[23] = "1";


            vowel[24] = "າ"; voSat[24] = "a"; voSound[24] = "2";
            vowel[25] = "ີ"; voSat[25] = "i"; voSound[25] = "2";
            vowel[26] = "ື"; voSat[26] = "ue"; voSound[26] = "2";
            vowel[27] = "ູ"; voSat[27] = "ou"; voSound[27] = "2";
            vowel[28] = "ເ"; voSat[28] = "e"; voSound[28] = "2";
            vowel[29] = "ແ"; voSat[29] = "ae"; voSound[29] = "2";
            vowel[30] = "ໂ"; voSat[30] = "o"; voSound[30] = "2";
            vowel[31] = "ໍ"; voSat[31] = "o"; voSound[31] = "2";
            vowel[32] = "ອ"; voSat[32] = "o"; voSound[32] = "2";
            vowel[33] = "ເ-ີ"; voSat[33] = "eu"; voSound[33] = "2";
            vowel[34] = "ເ-ຍ"; voSat[34] = "ai"; voSound[34] = "2";
            vowel[35] = "ຽ"; voSat[35] = "ai"; voSound[35] = "2";
            vowel[36] = "ເ"; voSat[36] = "ua"; voSound[36] = "2";
            vowel[37] = "ົວ"; voSat[37] = "ua"; voSound[37] = "2";
            vowel[38] = "-ວ-"; voSat[38] = "ua"; voSound[38] = "2";
            vowel[39] = "າຍ"; voSat[39] = "ai"; voSound[39] = "2";
            vowel[40] = " "; voSat[40] = " "; voSound[40] = "2";
        }
    }
}