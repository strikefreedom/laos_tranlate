using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace laos_project.fn_class
{
    public class main_fn
    {
        public static string main_fnc(string dt)
        {
            string[] data = dt.Split(' ');
            string word = "";         
            int index = 0;
            int index_tone = 0;
            int index_char=0;
            int index_charc = 0;
            int index_char2 = 0;
            for (int i = 0; i < data.Length; i++)
            {
                index = 0;
                index_char = 0;
                index_charc = 0;
                index_char2 = 0;
                index_tone = 0;
                //check char
                try
                   {
                    while (true)
                    {
                        if (fn_class.charector.check_char(data[i].Substring(index_char, 1)))
                        {
                            word += data[i].Substring(index_char, 1);
                            if (data[i].Substring(index_char, 1).Equals("ຫ"))
                            {
                            
                                    if (fn_class.charector.check_char(data[i].Substring(index_char + 1, 1)))
                                    {
                                        index_charc = index_char + 1;
                                        word += data[i].Substring(index_charc, 1);
                                    }
                            
                            }
                            break;
                        }
                        else index_char++;
                    }
                 }
                catch { }
                //check vowel
                while (true)
                {
                    if (index == data[i].Length) break;
                    if (fn_class.charector.check_vowel(data[i].Substring(index, 1)))
                    {
                        word += "-" + data[i].Substring(index, 1);
                    }
                    index = index + 1;
                }

                //ckeck ຕັວສະກດ
                while (true)
                {
                    if (fn_class.charector.check_char(data[i].Substring(index_char2, 1)))
                    {
                        if (index_char != index_char2 && index_charc != index_char2)
                        {
                            if (data[i].Substring(index_char2, 1).Equals("ອ") || data[i].Substring(index_char2, 1).Equals("ວ") || data[i].Substring(index_char2, 1).Equals("ຍ")) word += "-" + data[i].Substring(index_char2, 1);
                            else word += "/"+data[i].Substring(index_char2, 1);
                        }
                    }
                    index_char2++;
                    if (index_char2 == data[i].Length) break;
                }
                //check tone
                while (true)
                {
                    if (fn_class.charector.check_voweltone(data[i].Substring(index_tone, 1)))
                    {
                        word += "/" + data[i].Substring(index_tone, 1);
                    }
                    index_tone++;
                    if (index_tone == data[i].Length) break;
                }

                word += " ";
            }

            

            return word;
        }
    }
}