using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        Dictionary<int, string> meses = new Dictionary<int, string>();

        meses.Add(1, "January");
        meses.Add(2, "February");
        meses.Add(3, "March");
        meses.Add(4, "April");
        meses.Add(5, "May");
        meses.Add(6, "June");
        meses.Add(7, "July");
        meses.Add(8, "August");
        meses.Add(9, "September");
        meses.Add(10, "October");
        meses.Add(11, "November");
        meses.Add(12, "December");

        var mes = Int32.Parse(Console.ReadLine());

        Console.Write("{0}\n", meses[mes]);
    }
}