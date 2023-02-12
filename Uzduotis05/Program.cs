using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Išveskite į ekraną dviejų skaičių sumą, skirtumą, sandaugą ir dalmenį,
             * kiekvieną kartą nurodant atliekamą veiksmą ir šių skaičių reikšmes.
             * Pvz.: 
             * 4 + 5 = 9
             * 4 - 5 = -1
             * …
             */

            int skaicius1 = 4;
            int skaicius2 = 5;
            float skaicius3 = 4;
            float skaicius4 = 5;
            Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2} ");

            Console.WriteLine($"{skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");

            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2} ");

            Console.WriteLine($"{skaicius3} / {skaicius4} = {skaicius3 / skaicius4} ");




            /* 
             * Išveskite į ekraną pasirinktą skaičių, jo kvadratą ir jį pakeltą trečiuoju laipsniu.
             */

            int skaicius5 = 3;
            int skaicius6 = skaicius5 * skaicius5; // skaiciaus kvadrato suradimas
            Console.WriteLine($" ivesto skaiciaus {skaicius5} kvadratas lygus {skaicius6}"); //skaiciaus kvadrato isvestis

            int skaicius7 = (skaicius5 * skaicius5) * skaicius5; //skaiciaus treciuoju laipsniu pakelimas
            Console.WriteLine($" ivesto skaiciu {skaicius5} pekelus treciuoju laipsniu gauname {skaicius7}"); //skaiciaus treciuoju laipsniu isvedimas

            /*
             * Išveskite į ekraną trijų skaičių sandaugą.
             */

            int skaicius8 = 2;
            int skaicius9 = 4;
            int skaicius10 = 5;

            int sandauga = skaicius8 * skaicius9 * skaicius10; //sandauga

            Console.WriteLine($" ivestu skaiciu {skaicius8} , {skaicius9} ir {skaicius10} sandauga lygi {sandauga}"); //sandaugos isvestis


            /*
             * Išveskite į ekraną šių veiksmų atsakymus:
              1 uzduotis  -1 + 4 * 6
              2 uzduotis  14 + -4 * 6 / 11
              3 uzduotis  2 + 15 / 6 * 1 - 7 % 2
                Turite gauti: 23, 12, 3.
             */

             // 1 uzduotis 

            int skaicius_a = -1;
            int skaicius_b = 4;
            int skaicius_c = 6;

            int rezultatas = skaicius_a + skaicius_b * skaicius_c; //skaiciavimas

            Console.WriteLine($" 1 uzduotis: {skaicius_a} + {skaicius_b} * {skaicius_c} gauname {rezultatas}"); // isvestis

            // 2 uzduotis 

            int skaicius_a1 = 14;
            int skaicius_b1 = -4;
            int skaicius_c1 = 6;
            int skaicius_d1 = 11;

            int rezultatas1 = skaicius_a1 + skaicius_b1 * skaicius_c1 / skaicius_d1 ; //skaiciavimas

            Console.WriteLine($" 2 uzduotis: {skaicius_a1} + {skaicius_b1} * {skaicius_c1} / {skaicius_d1} gauname {rezultatas1}"); // isvestis

            // 3 uzduotis : 2 + 15 / 6 * 1 - 7 % 2

            int skaicius_a2 = 2;
            int skaicius_b2 = 15;
            int skaicius_c2 = 6;
            int skaicius_d2 = 1;
            int skaicius_e2 = 7;
            int procentai = 2;

            int rezultatas2 = skaicius_a2 + skaicius_b2 / skaicius_c2 * skaicius_d2 - skaicius_e2 % procentai; //skaiciavimas

            Console.WriteLine($" 3 uzduotis: {skaicius_a2} + {skaicius_b2} / {skaicius_c2} * {skaicius_d2} - {skaicius_e2} % {procentai} gauname {rezultatas2}"); // isvestis
        }
    }
}
