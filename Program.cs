using System;

namespace Badetidssystemet
{
   class Program
    {
        static void Main(string[] args)
        {



            Kreds kr = new Kreds("Aktivitet 1", "Svømning", "Betonvej", 12);
            Kreds kr1 = new Kreds("Aktivitet 2", "Svømning", "Asfaltvej", 9);
            Kreds kr2 = new Kreds("Aktivitet 3", "Svømning", "Asfaltvej", 8);
           
                BadetidsPeriode bp = new BadetidsPeriode("MorgenDukkert", DayOfWeek.Tuesday, new DateTime(2022, 6, 14, 7, 0, 0), new DateTime(2022, 6, 14, 13, 0, 0));
                BadetidsPeriode bp1 = new BadetidsPeriode("Aftensvaler", DayOfWeek.Saturday, new DateTime(2022, 6, 18, 19, 30, 0), new DateTime(2022, 6, 18, 22, 15, 0));
                BadetidsPeriode bp2 = new BadetidsPeriode("Aftensvaler", DayOfWeek.Saturday, new DateTime(2022, 6, 18, 19, 30, 0), new DateTime(2022, 6, 18, 18, 15, 0));
             
                
                Console.WriteLine("Opgave 1 : ");
                Console.WriteLine(kr);
                Console.WriteLine("''''''''''''''''''''''''''''''''''''''''''''''''");

                Console.WriteLine("Opgave 2 :");
                Console.WriteLine(bp);
                Console.WriteLine("''''''''''''''''''''''''''''''''''''''''''''''''");

                Console.WriteLine("Opgave 4 :");
                //oprettelses metode af 2 aktiviteter
                bp.Create(kr);
                bp1.Create(kr1);
                Console.WriteLine($"{bp}\n{bp1}");
                Console.WriteLine("''''''''''''''''''''''''''''''''''''''''''''''''");
                //Printer efter vi har fået fjernet ene af aktiviteterne

                 // Den sletter kr1
                 bp1.Remove(kr1.ID);
                 Console.WriteLine($"{bp}\n{bp1}\n");
                 Console.WriteLine( );
                 Console.WriteLine("'''''''''''''''''''''''''''''''''''''''''''''''''");




            Console.WriteLine("''''''''''''''''''''''''''''''''''''''''''''''''");
            bp2.Create(kr2);
            Console.WriteLine(kr2);
            Console.WriteLine("''''''''''''''''''''''''''''''''''''''''''''''''");


        }
    }
}
