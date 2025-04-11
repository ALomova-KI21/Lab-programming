using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Income
    {
        protected string date;
        protected string source;    //источник
        protected int amounte;    //сумма
        public string Date { get => date; set => date = value; }
        public string Source { get => source; set => source = value; }
        public int Amounte { get => amounte; set => amounte = value; }
        /// чтение
        public virtual void Read(string s)
        {

        }

        public virtual void Revenue()
        {
        }
    }
}

