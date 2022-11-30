using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentele_programarii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();
            //P17();
            //P18();
            //P19();
            //P20();
            //P21();
        }

        /// <summary>
        /// 1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
        /// </summary>
        private static void P1()
        {
            Console.WriteLine("Problema 1.");
            int a, b, x;
            Console.Write("Introduceti un numar a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar b = ");
            b = int.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                {
                    Console.WriteLine("Ecuatie nedeterminata, exista o ifinitate de solutii!");
                }
                else
                {
                    Console.WriteLine("Ecuatie imposibila!");
                }
            else
            {
                x = -b / a;
                Console.WriteLine($"Solutia ecuatiei este x = {x}");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. 
        /// Tratati toate cazurile posibile. 
        /// </summary>
        private static void P2()
        {
            Console.WriteLine("Problema 2.");
            float a, b, c, dt, x1, x2;
            Console.Write("Introduceti un numar a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar c = ");
            c = float.Parse(Console.ReadLine());
            dt = b * b - 4 * a * c;

            if (a == 0)
                if (b == 0)
                    if (c == 0)
                    {
                        Console.WriteLine("Ecuatie nedeterminata!");
                    }
                    else
                    {
                        Console.WriteLine("Ecuatie imposibila!");
                    }
                else
                {
                    x1 = -c / b;
                    Console.WriteLine("Ecuatie de gradul 1 cu x1 = " + x1);
                }

            if (dt < 0)
            {
                Console.WriteLine("Ecuatia are solutii complexe!");
            }
            if (dt == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("x1 = x2 = " + x1);
            }
            if (dt > 0)
            {
                x1 = (-b + (float)Math.Sqrt(dt)) / (2 * a);
                x2 = (-b - (float)Math.Sqrt(dt)) / (2 * a);
                Console.WriteLine("Solutiile ecuatiei sunt x1 = " + x1 + ", x2 = " + x2);
            }
            Console.ReadKey();

        }

        /// <summary>
        /// 3. Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
        /// </summary>
        private static void P3()
        {
            Console.WriteLine("Problema 3.");
            float n, k;
            Console.Write("Introduceti un numar n = ");
            n = float.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar k = ");
            k = float.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine("{0} se divide cu {1}", n, k);
            }
            else
            {
                Console.WriteLine(n + " nu se divide cu " + k);
            }
            Console.ReadKey();

        }

        /// <summary>
        /// 4. Detreminati daca un an y este an bisect. 
        /// </summary>
        private static void P4()
        {
            Console.WriteLine("Problema 4.");
            Console.Write("Introduceti un an = ");
            int y = int.Parse(Console.ReadLine());
            if ((y % 400 == 0) || (y % 4 == 0 && y % 100 != 0))
            {
                Console.WriteLine(y + " este an bisect.");
            }
            else
            {
                Console.WriteLine(y + " nu este an bisect.");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
        /// </summary>
        private static void P5()
        {
            Console.WriteLine("Problema 5.");
            Console.Write("Introduceti un numar = ");
            float n;
            n = float.Parse(Console.ReadLine());
            float k = n % 10;
            Console.WriteLine("Ultima cifra al numarului este = " + k);
            Console.ReadKey();

        }

        /// <summary>
        /// 6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        /// </summary>
        private static void P6()
        {
            Console.WriteLine("Problema 6.");
            float a, b, c;
            Console.Write("Introduceti un numar a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar c = ");
            c = float.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("{0}, {1} si {2} sunt laturile unui triunghi", a, b, c);
            }
            else
            {
                Console.WriteLine("{0}, {1} si {2} nu sunt laturile unui triunghi", a, b, c);
            }
            Console.ReadKey();

        }

        /// <summary>
        /// 7. (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 
        /// </summary>
        private static void P7()
        {
            Console.WriteLine("Problema 7.");
            float a, b, aux;
            Console.Write("Introduceti un numar a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar b = ");
            b = float.Parse(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine("Inverzele varolirol a, b sunt " + a + " si " + b);
            Console.ReadKey();
        }

        /// <summary>
        /// 8. Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
        /// Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  
        /// </summary>

        private static void P8()
        {
            Console.WriteLine("Problema 8.");
            float a, b;
            Console.Write("Introduceti un numar a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar b = ");
            b = float.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Inverzele varolirol sunt " + a + " si " + b);
            Console.ReadKey();
        }

        /// <summary>
        /// 9. Afisati toti divizorii numarului n. 
        /// </summary>

        private static void P9()
        {
            Console.WriteLine("Problema 9.");
            float n;
            Console.Write("Introduceti un numar n = ");
            n = float.Parse(Console.ReadLine());
            Console.Write("Divizorii numarului n sunt = ");
            for (float i = 0; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        /// <summary>
        /// 10. Test de primalitate: determinati daca un numar n este prim.
        /// </summary>

        private static void P10()
        {
            Console.WriteLine("Problema 10.");
            float n, x = 0;
            Console.Write("Introduceti un numar n = ");
            n = float.Parse(Console.ReadLine());
            for (float i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    x++;
                }
            }
            if (x == 2)
            {
                Console.WriteLine($"{n} este un numar prim");
            }
            else
            {
                Console.WriteLine($"Nu este un numar prim");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 11. Afisati in ordine inversa cifrele unui numar n. 
        /// </summary>

        private static void P11()
        {
            Console.WriteLine("Problema 11.");
            int n, k = 0, y;
            Console.Write("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                y = n % 10;
                k = (k * 10) + y;
                n = n / 10;
            }
            Console.Write("Ordinea inversa al numarului n este = " + k);
            Console.WriteLine();
            Console.ReadKey();


        }

        /// <summary>
        /// 12.Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
        /// </summary>

        private static void P12()
        {
            Console.WriteLine("Problema 12.");
            int n, a, b, k = 0;
            Console.Write("Introduceti un numar a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                {
                    k++;
                }
            }

            Console.WriteLine($"In intervalul [{a}, {b}] se afla {k} numere integi divizibile cu {n}.");
            Console.ReadKey();

        }

        /// <summary>
        /// 13. Determianti cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>

        private static void P13()
        {
            Console.WriteLine("Problema 13.");
            int y1, y2;
            Console.Write("Introduceti un an y1 = ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un an y2 = ");
            y2 = int.Parse(Console.ReadLine());

            int db = 0;
            for (int i = y1; i <= y2; i++)
            {
                if ((i % 400 == 0) || (i % 4 == 0 && i % 100 != 0))
                {
                    db++;
                }
            }
            Console.WriteLine("Intre anii " + y1 + " si " + y2 + ", " + db + " ani sunt bisecti.");
            Console.ReadKey();

        }

        /// <summary>
        /// 14. Determianti daca un numar n este palindrom. 
        /// (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
        /// </summary>


        private static void P14()
        {
            Console.WriteLine("Problema 14.");
            int n, sum = 0, k, copie;
            Console.Write("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());
            copie = n;
            while (n > 0)
            {
                k = n % 10;
                sum = (sum * 10) + k;
                n = n / 10;
            }
            if (copie == sum)
            {
                Console.WriteLine($"Numarul {copie} este palindrom");
            }
            else
            {
                Console.WriteLine("Numarul nu este palindrom");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 15. Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
        /// </summary>

        private static void P15()
        {
            Console.WriteLine("Problema 15.");
            int a, b, c;
            Console.Write("Introduceti un numar a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar c = ");
            c = int.Parse(Console.ReadLine());

            int aux;
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            Console.WriteLine($"Ordinea crescatoare a numerelor este {a} {b} {c}");
            Console.ReadKey();
        }

        /// <summary>
        /// 16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
        /// </summary>


        public static void swap(ref int num1, ref int num2)
        {
            int aux;

            aux = num1;
            num1 = num2;
            num2 = aux;
        }

        private static void P16()
        {
            Console.WriteLine("Problema 16.");
            int a, b, c, d, e;

            Console.Write("Introduceti un numar a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar c = ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar d = ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar e = ");
            e = int.Parse(Console.ReadLine());

            if (a > b) { swap(ref a, ref b); }
            if (a > c) { swap(ref a, ref c); }
            if (a > d) { swap(ref a, ref d); }
            if (a > e) { swap(ref a, ref e); }
            if (b > c) { swap(ref b, ref c); }
            if (b > d) { swap(ref b, ref d); }
            if (b > e) { swap(ref b, ref e); }
            if (c > d) { swap(ref c, ref d); }
            if (c > e) { swap(ref c, ref e); }
            if (d > e) { swap(ref d, ref e); }



            Console.WriteLine($"{a} {b} {c} {d} {e} ");
            Console.ReadKey();
        }

        /// <summary>
        /// 17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
        /// </summary>

        private static void P17()
        {
            Console.WriteLine("Problema 17.");
            int a, b, r, x;
            Console.Write("Introduceti un numar a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar b = ");
            b = int.Parse(Console.ReadLine());

            x = a * b;
            r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            x = x / b;
            Console.WriteLine("Cel mai mare divizor comun este " + b + ", iar cel mai mic multiplu comun este " + x + ".");
            Console.ReadKey();

        }

        /// <summary>
        /// 18. Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. 
        /// </summary>

        private static void P18()
        {
            Console.WriteLine("Problema.18");
            int n, k, div = 2;

            Console.Write("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());

            while (n != 1)
            {
                k = 0;
                while (n % div == 0)
                {
                    k++;
                    n = n / div;
                }
                if (k != 0)
                    Console.Write($"x {div}^{k} ");
                div++;
                if (n > 1 && div * div > n)
                {
                    div = n;
                }
            }
            Console.WriteLine();
            Console.ReadKey();

        }

        /// <summary>
        /// 19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta. 
        /// De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
        /// </summary>

        private static void P19()
        {
            Console.WriteLine("Problema.19");

            int numarOriginal;
            Console.Write("Introduceti un numar e = ");
            numarOriginal = int.Parse(Console.ReadLine());

            bool[] numUsed = new bool[10];
            int counter = 0;

            // Parcurgem numarul si umplem matricea cu numerele gasite in numar
            while (numarOriginal > 0)
            {
                int ultimulNumar = numarOriginal % 10;
                numarOriginal = numarOriginal / 10;
                for (int j = 0; j < numUsed.Length; j++)
                {
                    if (ultimulNumar == j)
                    {
                        numUsed[j] = true;
                    }
                }
            }


            // Numaram cate numere sunt true
            for (int i = 0; i < numUsed.Length; i++)
            {
                if (numUsed[i] == true)
                {
                    counter++;
                }
            }


            if (counter == 2)
            {
                Console.WriteLine($"Numarul este format din {counter} cifre");
            }
            else
            {
                Console.WriteLine($"Numarul NU este format din 2 cifre... este format din {counter} cifre");
            }
        }

        /// <summary>
        /// 20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). (https://github.com/HoreaOros/ROSE2020/blob/master/2611/Program.cs)
        ///  O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0 
        ///  O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. 
        ///  O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5. 
        /// </summary>

        private static void P20()
        {
            int m, n;
            Console.Write("Introduceti un numar m = ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());

            int parteInt, parteFract;
            parteInt = m / n;
            parteFract = m % n;

            Console.Write($"{parteInt},");
            int cifra, rest;

            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();

            resturi.Add(parteFract);
            bool periodic = false;

            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                //Console.Write($"{cifra}");
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            }
            while (rest != 0);
            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }

        /// <summary>
        /// 21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 
        /// </summary>

        private static void P21()
        {
            Console.WriteLine();
            Console.WriteLine("Problema 21: Ghiciti un numar intre 1 si 1024");
            Console.WriteLine();

            Random rnd = new Random();
            int numarulAles = rnd.Next(1024);
            int nrInput;

            do
            {
                Console.Write("Introduceti un numar: ");
                nrInput = int.Parse(Console.ReadLine());

                if (nrInput == numarulAles)
                {
                    Console.WriteLine("Ai ghicit numarul! Felicitari");
                    Console.WriteLine();
                }
                else if (nrInput < numarulAles)
                {
                    Console.WriteLine("Numarul este prea mic!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Numarul este prea mare");
                    Console.WriteLine();
                }
            }
            while (nrInput != numarulAles);
        }
    }

}
        


    

