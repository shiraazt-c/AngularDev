﻿using EIS.BLL;
using EIS.BOL;
using System.Data.Entity;

namespace EIS.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  RoleBs ObjBs = new RoleBs();
              var roles = ObjBs.GetALL();
              foreach (var item in roles)
              {
                  System.Console.WriteLine(item.RoleName);
              }
            */
            QuoteBs ObjBs = new QuoteBs();
            var quotes = ObjBs.GetALL();
            foreach (var item in quotes)
            {
                System.Console.WriteLine(item.QuoteText + ' '+ item.Author);
            }

        }
    }
}
