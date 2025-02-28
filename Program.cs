using System;
using Lab1;

public class WorkWithFile
{
    static void Main()
    {
        Active someActive = new Active();

        Passive somePassive = new Passive();

        Income income = new Income();

        List<Income> finances = new List<Income>();


        StreamReader file = new StreamReader("/Users/Александра/Documents/Учёба/Технологии и методы программирования/test.txt");
        while (!file.EndOfStream)  
        {
            string s = file.ReadLine();

            if (s.Split()[0] == "Активный:")
            {
                someActive.Read(s);
                someActive.Revenue();
                finances.Add(someActive);
            }

            if (s.Split()[0] == "Пассивный:")
            {
                somePassive.Read(s);
                somePassive.Revenue();
                finances.Add(somePassive);
            }

        }
        file.Close();
    }
}