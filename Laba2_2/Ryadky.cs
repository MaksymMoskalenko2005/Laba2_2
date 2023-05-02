using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_2
{
    class Ryadky
    {
        public string ryadok = "";
        public virtual int length()
        {
            return ryadok.Length;
        }
        public virtual void delete(string c)
        {
            ryadok = ryadok.Replace(c,"");   
        }
        public virtual bool check()
        {
            return true;
        }

    }
    
}
