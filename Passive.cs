using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Passive : Income
    {
        protected string payer;
        protected string period;

        public override void Read(string s)
        {
            date = s.Split()[1];
            source = s.Split()[2];
            amounte = int.Parse(s.Split(' ')[3]);
            payer = s.Split()[4];
            period = s.Split()[5];

        }
        public override void Revenue()
        {
            Console.WriteLine("Доход на " + date + " источник: " + source + " сумма дохода: " + amounte + " плательщик: " + payer + " период выплат: " + period);
            //return $"date: {date}, source: {source}, amounte: {amounte}, payer: {payer}, period: {period}";
        }
    }
}