namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*char A = 'S';
            string B1 = "Hello, World!";
            string B2 = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.";
            byte  C = 255;
            sbyte D = -128;
            int E = 123456789;
            short F = 12345;
            long G = 23456789123456;
            bool H = true;
            bool I = false;
            float J = 25.89f;
            decimal K = 1322222222222222222.9877777777777777777777764444444444444444421333333333333545444446m;
            double L = 1322222222222222222.98777777777777777777777644444444444444444213333333333335454444462311111111111111111111455555555555555555556;

            Console.WriteLine(A);
            Console.WriteLine(B1);
            Console.WriteLine(B2 + "\n");
            Console.WriteLine(C);
            Console.WriteLine(D);
            Console.WriteLine(E);
            Console.WriteLine(F);
            Console.WriteLine(G);
            Console.WriteLine(H);
            Console.WriteLine(I);
            Console.WriteLine(J);
            Console.WriteLine(K);
            Console.WriteLine(L + "\n");
            Console.WriteLine("Total of all variables except Boolean, Float and Decimal:");
            Console.WriteLine(C * D / E - F + G * L + "\n");*/

            /*Console.WriteLine("Employee Form\n");

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your phone number:");
            int phone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your designation:");
            string desg = Console.ReadLine();

            Console.WriteLine("Create your password:");
            string pass = Console.ReadLine();

            Console.WriteLine("Retype your password:");
            string rpass = Console.ReadLine();

            if(pass == rpass)
            {
                // Console.WriteLine("Dear " + name + " your data is saved succesfully!");

                Console.WriteLine("Please confirm that data you entered is correct? True or False");
                bool confirmation = bool.Parse(Console.ReadLine());

                if (confirmation == true)
                {
                    Console.WriteLine("Dear " + name + " your data is saved succesfully!");
                }
                else
                {
                    Console.WriteLine("Sorry the data you entered is in correct, try again and complete the form with correct data!");
                }
            }
            else
            {
                Console.WriteLine("Password and retype password doesn't match!");
            }*/

            /*Console.WriteLine("Calculator!\n");
            Console.WriteLine("Enter first number:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The result after addition is "+n1+" + "+n2+" = " + (n1 + n2));
            Console.WriteLine("The result after substraction is " + n1 + " - " + n2 + " = " + (n1 - n2));
            Console.WriteLine("The result after multiplication is " + n1 + " * " + n2 + " = " + (n1 * n2));
            Console.WriteLine("The result after divison is " + n1 + " / " + n2 + " = " + (n1 / n2));*/

            /*Console.WriteLine("Calculator with your given operator!\n");
            Console.WriteLine("Enter first number:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter operator for calculation (+, -, *, /)");
            string oper = Console.ReadLine();

            Console.WriteLine("Enter second number:");
            int n2 = int.Parse(Console.ReadLine());

            switch (oper)
            {
                case "+":
                    Console.WriteLine("The result after addtion is " + (n1 + n2));
                    break;

                case "-":
                    Console.WriteLine("The result after substraction is " + (n1 - n2));
                    break;

                case "*":
                    Console.WriteLine("The result after multiplication is " + (n1 * n2));
                    break;

                case "/":
                    Console.WriteLine("The result after divison is " + (n1 / n2));
                    break;

                default:
                    Console.WriteLine("Error! The operator you entered is not correct");
                    break;
            }*/

            /*Console.WriteLine("Enter any alphabet and we will check is it vowel or not:");
            string a = Console.ReadLine();

            switch (a.ToLower()) //.ToLower() is se agar hamne case small mn diye hai or ham capital mn likh rahe hain to ye automatically small mn kardega  
            {
                case "a":
                    Console.WriteLine(a + " is a vowel.");
                    break;

                case "e":
                    Console.WriteLine(a + " is a vowel.");
                    break;

                case "i":
                    Console.WriteLine(a + " is a vowel.");
                    break;

                case "o":
                    Console.WriteLine(a + " is a vowel.");
                    break;

                case "u":
                    Console.WriteLine(a + " is a vowel.");
                    break;

                default:
                    Console.WriteLine(a + " is not a vowel.");
                    break;
            }*/

            /*int num = 100;
            switch (num)
            {
                case 100:
                    Console.WriteLine(num + " = " + 100);
                    break;
                case 200:
                    Console.WriteLine(num + " = " + 200);
                    break;
                default:
                    Console.WriteLine("Value not matched");
                    break;
            }*/

            //Loops:

            /*for (int a = 1; a <= 10; a++)
            {
                Console.WriteLine("New number is " + a);
            }

            for (int b = 10; b >= 1; b--)
            {
                Console.WriteLine("Student " + b);
            }

            for (int c = 1; c <= 20; c = c + 1)
            {
                Console.WriteLine(c);
            }

            for (int d = 20; d >= 1; d = d - 1)
            {
                Console.WriteLine(d);
            }

            for (int e = 1; e <= 20; e = e + 2)
            {
                Console.WriteLine(e);
            }

            for (int f = 15; f >= 1; f = f - 2)
            {
                Console.WriteLine(f);
            }

            for (int g = 2; g <= 20; g = g + 2)
            {
                Console.WriteLine(g);
            }

            for (int h = 16; h >= 2; h = h - 2)
            {
                Console.WriteLine(h);
            }*/

            /*for(int a=1; a<=10; a++)
            {
                Console.WriteLine("7 x "+a+" = "+(7*a));
            }
            Console.WriteLine("\n");
            for(int b=10; b>=1; b--)
            {
                Console.WriteLine("7 x " + b + " = " + (7 * b));
            }*/

            /*Console.WriteLine("Public Table!\n");

            Console.WriteLine("Jiska table chahiye wo number daalen:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Table kis number se start ho?");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ye table kahan tak chale?");
            int n3 = int.Parse(Console.ReadLine());

            for(int a = n2; a<=n3; a++)
            {
                Console.WriteLine(n1 + " x " + a + " = " + (n1 * a));
            }*/

            /*Console.WriteLine("Public Table!\n");
            Console.WriteLine("Jiska table chahiye wo number daalen:");
            int a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Table kis number se start ho?");
            int a2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ye table kahan tak chale?");
            int a3 = int.Parse(Console.ReadLine());


            if (a2 < a3)
            {
                for (int i = a2; i <= a3; i++)
                {
                    Console.WriteLine(a1 + " x " + i + " = " + (a1 * i));
                }
            }

            else
            {
                for (int i = a2; i >= a3; i--)
                {
                    Console.WriteLine(a1 + " x " + i + " = " + (a1 * i));
                }
            }

            if (a2 > a3)
            {
                for (int i = a2; i >= a3; i--)
                {
                    Console.WriteLine(a1 + " x " + i + " = " + (a1 * i));
                }
            }*/

            /*Console.WriteLine("Enter any number for table, also enter first and last number for multiply!");
            int t, s, e;
            t = int.Parse(Console.ReadLine());
            s = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            int a = s;
            while (a <= e)
            {
                Console.WriteLine(t + " x " + a + " = " + (t * a));
                a++;
            }
            int b = s;
            while (b >= e)
            {
                Console.WriteLine(t + " x " + b + " = " + (t * b));
                b--;
            }*/

            /*Console.WriteLine("Enter any number for table, also starting and ending number:");
            int t, s, e;
            t = int.Parse(Console.ReadLine());
            s = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            if (s < e)
            {
                int i = s;
                do
                {
                    Console.WriteLine(t + " x " + i + " = " + (t * i));
                    i++;
                } while (i <= e);
            }
            else
            {
                int i = s;
                do
                {
                    Console.WriteLine(t + " x " + i + " = " + (t * i));
                    i--;
                } while (i >= e);
            }*/

            // OOP in C#:

            /*Class1 a = new Class1();                      // making class
            a.abc();                                        // calling void
            Console.WriteLine(a.def());                     // calling datatypes
            Console.WriteLine(a.ghi());                     // calling datatypes
            Console.WriteLine(a.jkl(123456));               // calling datatypes
            Console.WriteLine(a.mno("Saad Ziauddin!"));     // calling datatypes
            Console.WriteLine(a.mno("Ahmed!"));             // calling datatypes
            Console.WriteLine(a.mno("Zaid!"));              // calling datatypes
            a.pqr("Saad Ziauddin!");                        // calling void
            a.pqr("Ahmed!");                                // calling void
            a.table();*/

            /* Class1.abc("Saad");                             // calling static method         
            Class1.abc("Saad", "Ziauddin");                 // calling static method
            Class1.abc("Saad", 20);*/                         // calling static method
        }
    }
}