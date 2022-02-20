using System;
using System.Numerics;
using System.IO;
namespace tema_19_02_2022
{
    class Program
    {
        static void Main(string[] args)
        {






            //1
            /*     int    a ;

                 String aS;




                 bool w = true;
                 while (w)
                 {
                     Console.WriteLine("insert value ");

        aS = Console.ReadLine();
        a = Convert.ToInt32(aS);



                     if (a < 100 && a > 1)
                     {
                         Console.WriteLine("Ce ai inserat " + a);


                         if (a == 15 || a == 90)

                         { Console.WriteLine(" multiplul lui 3 si 5, FIzz - Buzz " + a); w = false; }


                         else if (a == 3 || a == 9 || a == 12 || a == 15 || a == 18 || a == 21 || a == 24 || a == 27 || a == 30 || a == 33 || a == 36 || a == 39 || a == 42)

                         { Console.WriteLine(" multiplul lui 3 , FIzz " + a); w = false; }


                         else if (a == 5 || a == 10 || a == 15 || a == 20 || a == 25 || a == 30 || a == 35 || a == 40 || a == 45 || a == 50)
                         {

                             Console.WriteLine(" multiplul lui 5 , Buzz " + a);

                             w = false;
                         }

                     }

                     else { Console.WriteLine("Error" + " in the range from 1 to 100  required"); }





                 }







             
             
             */






            //2
            /*
            String a, c;

            double a1, c2;

  Console.WriteLine(" insert  number ");
            a = Console.ReadLine();
          
     a1 = Convert.ToDouble(a);
     Console.WriteLine(" number is  " + a1);





     Console.WriteLine(" insert percentage ");
             c = Console.ReadLine();
            c2 = Convert.ToDouble(c);



            Console.WriteLine(" percentage is " +c );

           double  rez= a1 * c2 / 100;

            Console.WriteLine(" percentage  " + c+ " of " +a1 +"  is = "+rez);
*/



            //3

            /*
                        String user;
                        int a ;

                        user = Console.ReadLine();

                        a = Convert.ToInt32(user);

                        user = Console.ReadLine();

                        a = Convert.ToInt32(user);


                        user = Console.ReadLine();

                        a = Convert.ToInt32(user);

                        user = Console.ReadLine();

                        a = Convert.ToInt32(user);



                        Console.WriteLine(a+""+a + "" + a + "" + a);
             */


            //4
            /* String insert;
             int[] a = new int[6];


             Console.WriteLine("insert number in Vector ");
             for (int i = 0; i < a.Length; i++)
             {insert = Console.ReadLine();
                 a[i] = Convert.ToInt32(insert); }



             Console.WriteLine("     ");


             for (int i=0; i < a.Length; i++)


             {Console.WriteLine(a[i]);}

             Console.WriteLine("Select first number ");

             String s,s2;

             s = Console.ReadLine();
             Console.WriteLine("Select second number ");

             s2 = Console.ReadLine();
             int selectedNumber, selectedNumber2;

             selectedNumber = Convert.ToInt32(s);
             selectedNumber2 = Convert.ToInt32(s2);

             Console.WriteLine(" ------------ ");

             int c = 0;

             bool c1 = true;
             bool c2 = true;
             for (int i = 0; i < a.Length; i++)


             {

                 if (a[i] == selectedNumber ) { a[i] = selectedNumber2; c=i;  }


                 if (a[i] == selectedNumber2 && i != c) { a[i] = selectedNumber;  }


                 Console.WriteLine(a[i]); 


             }

             Console.WriteLine("    ");


             Console.WriteLine("Number changed");
             for (int i = 0; i < a.Length; i++)


             { Console.WriteLine(a[i]); }


             */



            //5


            /*

            Console.WriteLine("insereaza anult , luna  si ziua");

            String a;
              DateTime a1;
           a = Console.ReadLine();
          a1 = Convert.ToDateTime(a);
          
         Console.WriteLine(a1.ToString("D"));
            
            switch (a1.Month)

              {

                  case 1 :
                      Console.WriteLine(" iarna  ");

                      break;
                case 2:
                    Console.WriteLine(" iarna  ");

                    break;

                case 12:
                    Console.WriteLine(" iarna  ");

                    break;


                case 3:
                    Console.WriteLine(" Pimavara  ");

                    break;


                case 4:
                    Console.WriteLine(" Pimavara  ");

                    break;


                case 5:
                    Console.WriteLine(" Pimavara  ");

                    break;


                case 6:
                    Console.WriteLine(" Vara  ");

                    break;


                case 7:
                    Console.WriteLine(" Vara  ");

                    break;

                case 8:
                    Console.WriteLine(" Vara  ");

                    break;


                case 9:
                    Console.WriteLine(" Toamna   ");

                    break;


                case 10:
                    Console.WriteLine(" Toamna  ");

                    break;


                case 11:
                    Console.WriteLine(" Toamna  ");

                    break;

            }
              
            */

            //6

            //    Fahrenheit, Celsius, °F = (°C × 1,8) +32;
            //Celsius, Fahrenheit, °C = (°F − 32) ÷ 1,8 ;
            /*
                        double F, C;

                        String alegere ,insert;
                        Console.WriteLine("Alegeti tipul de scara a temperature , celsius sau fahrenheit ");
                        alegere = Console.ReadLine();

                        if (alegere.Equals("celsius"))
                        {

                            Console.WriteLine(" inserati in fahrenheit pentru a converti in Celesiu");

                            insert = Console.ReadLine();
                            F = Convert.ToDouble(insert);

                            C = (F - 32) / 1.8;

                            Console.WriteLine("Celsiu = " + C);
                        }

                        else if (alegere.Equals("fahrenheit"))
                        {
                            Console.WriteLine("inserati in Celesiu  pentru a converti in Fahrenheit  ");

                            insert = Console.ReadLine();
                            C = Convert.ToDouble(insert);
                            F = (C * 1.8) + 32;

                            Console.WriteLine("fahrenheit = " + F);
                        }
                        else { Console.WriteLine("ati selectat gresti !"); }


                        */

            //7
            int a, b;


            String a1, b1;

            a1 = Console.ReadLine();
            b1 = Console.ReadLine();
            a = Convert.ToInt32(a1);
            b = Convert.ToInt32(b1);


            Console.WriteLine("    ");

            if ( b>a )
            {


                Console.WriteLine("    ");


                for (int c1 = a; c1 < b; c1++)
                {
                    if (c1 % 2 == 0) {Console.WriteLine(c1); } 


                }
            }

            else

            {


                Console.WriteLine("    ");
                for (int c1 = b; c1 < a; c1++)
                {
                    if (c1 % 2 == 0) { Console.WriteLine(c1); }


                }
            }




        }



    }
}







