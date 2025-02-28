using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Income
    {
        protected string date;
        protected string source;    //источник
        protected int amounte;    //сумма

        /// чтение
        public virtual void Read(string s)
        {

        }

        public virtual void Revenue()
        {
        }
    }
}
