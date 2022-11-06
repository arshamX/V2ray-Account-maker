using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constants;
using IronBarCode;

namespace Mthods
{
    internal class Calculate
    {
        private Random rnd = new Random();
        public string idMaker()
        {
            string c1, c2, c3, c4, c5;
            c1 = cellMaker(8);
            c2 = cellMaker(4);
            c3 = cellMaker(4);
            c4 = cellMaker(4);
            c5 = cellMaker(12);
            return $"{c1}-{c2}-{c3}-{c4}-{c5}";
        }
        private string cellMaker(int len)
        {
            string cell = "";
            for(int i = 0;i< len;i++)
            {
                cell += Information.CHARS[rnd.Next(Information.CHARS.Length)];
            }
            return cell;
        }
    }
}
