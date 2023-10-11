using System;

namespace Date
{
    class Project
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual o formato de data você deseja visualizar");
            Console.WriteLine("1 - Utilizar minha configuração de sistema: 08/01/2021 20:48:13  ");
            Console.WriteLine("2 - Formato simples: 08-01-21");
            Console.WriteLine("3 - Formato longo sexta-feira, 8 de janeiro de 2021");
            Console.WriteLine("4 - Formato longo personalizado 08-01-2021 08:48:13");
            Console.WriteLine("5 - Formato RFC1123 pattern Fri, 08 Jan 2021 20:48:13 GMT");
            int date = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (date == 1)
            {
                DateTime date1 = DateTime.Now;
                Console.WriteLine(date1);
            }
            else if (date == 2)
            {
                DateTime date2 = new DateTime(2021, 8, 1,0 ,0 ,0);
                Console.WriteLine(date2.ToShortDateString());

            }
            else if ( date == 3)
            {
                DateTime date3 = DateTime.Now;
                string formattedDate = date3.ToLongDateString();
                Console.WriteLine(formattedDate);
            }
            else if ( date == 4)
            {
                DateTime date4 = new DateTime(2021, 1, 8, 08, 48, 13);
                Console.WriteLine(date4);
            }
            else if( date == 5)
            {
                DateTime date5 = new DateTime(2021, 1, 8, 20, 48, 13);

                string formattedDate = date5.ToString("ddd, dd MMM yyyy HH:mm:ss 'GMT'");
                Console.WriteLine(formattedDate);
            }
        }
    }
}