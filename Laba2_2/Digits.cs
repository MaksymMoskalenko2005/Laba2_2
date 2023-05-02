using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_2
{
    class Digits : Ryadky
    {

        public Digits(string ryadok)
        {
            this.ryadok = ryadok;
        }
        public override int length()
        {
            return base.length();
        }
        public virtual void delete()
        {
            ryadok = ryadok.Replace("5", "");
        }
        public virtual bool check()
        {
            bool result = true;
            for (int i = 0; i < ryadok.Length; i++)
            {

                if (!(ryadok[i] >= '0' && ryadok[i] <= '9'))
                {
                    result = false;
                    break;
                }
                else result = true;
            }
            return result;
        }
    }
}
