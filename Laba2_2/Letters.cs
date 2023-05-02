using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_2
{
    class Letters:Ryadky
    {
        public Letters(string ryadok)
        {
            this.ryadok = ryadok;
        }
        public override int length()
        {
            return base.length();
        }
        public virtual void delete()
        {
            ryadok = ryadok.Replace("a", "");
        }
        public virtual bool check()
        {
            bool result = true;
            for (int i = 0; i < ryadok.Length; i++)
            {

                if (!(ryadok[i] >= 'a' && ryadok[i] <= 'z'))
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
