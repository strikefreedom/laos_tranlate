using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace laos_project.fn_class
{
    public class main_fn
    {
        public static string main_fnc(string data)
        {
            string word = "";         
            int index = 0;
            int index_char=0;
            string ret = "";
                    //check char
                    while (true)
                    {

                        if (fn_class.charector.check_char(data.Substring(index_char, 1)))
                        {
                            word += data.Substring(index_char, 1);
                            if (data.Substring(index_char, 1).Equals("ຫ"))
                            {
                                if (fn_class.charector.check_char(data.Substring(index_char + 1, 1)))
                                {
                                    word += "_" + data.Substring(index_char, 1);
                                }
                            }
                            break;
                        }
                        else index_char++;
                    }
                    
                    //check vowel
                    while (true)
                    {
                        if (index == data.Length) break;
                        if (fn_class.charector.check_vowel(data.Substring(index, 1)))
                        {
                            word += "," + data.Substring(index, 1);       
                        }
                        index = index + 1;
                    }
            return word;
        }
    }
}