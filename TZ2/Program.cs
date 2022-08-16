using System;
using System.Collections.Generic;

namespace TZ2
{

    class Validator
    {

        public bool Validate(string param)
        {
            var param1 = param.ToCharArray();
            Stack<char> temp = new Stack<char>();
            var p = new Dictionary<char, char> {{ ')', '(' },{ ']' , '[' }, { '}','{'} };
            foreach (var item in param1)
            {
                if (item == '(' || item == '[' || item == '{')
                {
                    temp.Push(item);
                }
                else
                {
                    if (temp.Count > 0)
                    {

                        if (p[item] != temp.Pop())
                            {
                                return false;
                            }
                        
                    }
                    else
                    {
                        return false;

                    }

                }

            }
            if (temp.Count != 0) return false;
            return true;
        }
        static void Main()
        {

            Validator test = new Validator();
            Console.WriteLine(test.Validate("{()()()[]}{}{}"));
        }

    }

}
