using System;

namespace uzduotis_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                       5  Išveskite pasirinkto skaičiaus daugybos lentelę. 
                            Pvz.: 
                            5 * 0 = 0
                            5 * 1 = 5
                                …
                            5 * 10 = 50

                       6   Susikurkite sveikojo skaičiaus kintamąjį su dviženklio skaičiaus reikšme. Išveskite į ekraną šio skaičiaus skaitmenų sandaugą.

                        */


            // 5 uzduotis 

            int skaicius_a = 7;
            int skaicius_b = 0;

            int rezultatas = skaicius_a * skaicius_b; //skaiciavimas
            Console.WriteLine($"{skaicius_a} * {skaicius_b} = {rezultatas}"); // isvestis
            int rezultatas1 = skaicius_a * ++skaicius_b; //skaiciavimas
            Console.WriteLine($"{skaicius_a} * {skaicius_b} = {rezultatas1}"); // isvestis
            int rezultatas2 = skaicius_a * ++skaicius_b; //skaiciavimas
            Console.WriteLine($"{skaicius_a} * {skaicius_b} = {rezultatas2}"); // isvestis
            int rezultatas3 = skaicius_a * ++skaicius_b; //skaiciavimas
            Console.WriteLine($"{skaicius_a} * {skaicius_b} = {rezultatas3}"); // isvestis
            int rezultatas4 = skaicius_a * ++skaicius_b; //skaiciavimas
            Console.WriteLine($"{skaicius_a} * {skaicius_b} = {rezultatas4}"); // isvestis
            int rezultatas5 = skaicius_a * ++skaicius_b; //skaiciavimas
            Console.WriteLine($"{skaicius_a} * {skaicius_b} = {rezultatas5}"); // isvestis
            int rezultatas6 = skaicius_a * ++skaicius_b; //skaiciavimas
            Console.WriteLine($"{skaicius_a} * {skaicius_b} = {rezultatas6}"); // isvestis
            int rezultatas7 = skaicius_a * ++skaicius_b; //skaiciavimas
            Console.WriteLine($"{skaicius_a} * {skaicius_b} = {rezultatas7}"); // isvestis
            int rezultatas8 = skaicius_a * ++skaicius_b; //skaiciavimas
            Console.WriteLine($"{skaicius_a} * {skaicius_b} = {rezultatas8}"); // isvestis
            int rezultatas9 = skaicius_a * ++skaicius_b; //skaiciavimas
            Console.WriteLine($"{skaicius_a} * {skaicius_b} = {rezultatas9}"); // isvestis
            int rezultatas10 = skaicius_a * ++skaicius_b; //skaiciavimas
            Console.WriteLine($"{skaicius_a} * {skaicius_b} = {rezultatas10}"); // isvestis

            // 6 uzduotis 

            int skaicius_aa = 62;
            int pirmas_skaitmuo = skaicius_aa / 10;
            int antras_skaitmuo = skaicius_aa - pirmas_skaitmuo * 10;
            int sk_sandauga = pirmas_skaitmuo * antras_skaitmuo;


            Console.WriteLine($" Sveiko skaiciaus kintamojo {skaicius_aa} skaitmenu sandauga lygi : {sk_sandauga} "); // isvestis
        }
    }
}
