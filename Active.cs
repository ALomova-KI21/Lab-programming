﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1;

namespace Lab1
{
    public class Active : Income
{
    protected int hours;
    public override void Read(string s)
    {
        date = s.Split()[1];
        source = s.Split()[2];
        amounte = int.Parse(s.Split(' ')[3]);
        hours = int.Parse(s.Split(' ')[4]);
    }
    public override void Revenue()
    {

        Console.WriteLine("Доход на " + date + " источник: " + source + " сумма дохода: " + amounte + " отработано часов: " + hours);
    }
}
}
