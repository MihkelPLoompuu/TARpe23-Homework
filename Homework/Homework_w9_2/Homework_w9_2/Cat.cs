using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_w9_2
{
    internal class Cat
    {
        public bool CatIsPlaying(bool isSummer, int temp)
        {
            if (isSummer)
            {
                return temp >= 25 && temp <= 45;
            }
            else
            {
                return temp >= 25 && temp <= 35;
            }
        }
    }
}
