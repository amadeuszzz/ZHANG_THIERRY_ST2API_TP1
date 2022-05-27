using System;

namespace TP1_API
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comment / Uncomment in order to choose what to execute

            //Ex1.1
            Ex1Part1();

            //Ex1.2
            //Ex1Part2();

            //Ex1.3
            //Ex1Part3();

            //Ex2.1
            //Prime();

            //Ex2.2
            //Console.WriteLine(F(AskUserForParameter()));

            //Ex2.3
            //Console.WriteLine(Factorial(AskUserForParameter()));

            //Ex2.3.c
            //If we use 420.000 as an input the result will be 1
            //since when we read the input we use a TryParse
            //which mean that if a parameter is not a integer it will return 0
            //and factorial of 0 is 1.

            //Ex2.3.d
            //A recursive function is a function that can call itsefl multiple time in order
            //to compute the result.

            //Ex3
            //TryCatch();

            //Ex4.1
            //Rectangle();

            //Ex4.2
            //RectangleStar();

            //Ex5.1
            //ChrismasTree();

            //Ex5.2
            //ChrismasTreeDecorated();
        }

        private static void Ex1Part1()
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + (i * j));
                }
            }
        }

        private static void Ex1Part2()
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (i * j % 2 == 1)
                    {
                        Console.WriteLine(i + " * " + j + " = " + (i * j));
                    }
                }
            }
        }

        private static void Ex1Part3()
        {
            int n = AskUserForParameter();
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + " * " + n + " = " + (i * n));
            }
        }

        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        private static void Prime()
        {
            for (int j = 1; j <= 1001; j++)
            {
                bool prime = true;

                for (int i = 2; i <= j / 2; i++)
                {
                    if (j % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime && j != 1)
                    Console.WriteLine(j);
            }
        }

        private static int F(int n)
        {
            if (n <= 2)
                return 1;
            else
                return F(n- 1) + F(n - 2);
        }

        private static int Factorial(int n)
        {
            if (n == 0){
                return 1;
            }
            return n * Factorial(n - 1);
        }

        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }

        private static void TryCatch()
        {
            for(int i = -3; i<4; i++)
            {
                try
                {
                    Console.WriteLine(10 / PowerFunction(i));
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine("Can't divide by 0");
                }
                
            }
        }

        private static void Rectangle()
        {
            try
            {
                Console.WriteLine("Please enter the dimension of the rectangle between 1 and 1000 (line then column) example : 2 3");
                string[] inputs = Console.ReadLine().Split();

                //line
                int n = int.Parse(inputs[0]);

                //column
                int m = int.Parse(inputs[1]);

                if(n == 0 || m == 0 || n > 1000 || m > 1000)
                {
                    Rectangle();
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        string line = "";
                        for (int j = 1; j <= m; j++)
                        {
                            if ((i == 1 && j == 1) || (i == 1 && j == m) || (i == n && j == 1) || (i == n && j == m))
                                line += "0";
                            else if (i == 1 || i == n)
                                line += "-";
                            else if (j == 1 || j == m)
                                line += "|";
                            else
                                line += " ";
                        }
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception e)
            {
                Rectangle();
            }
        }

        
        private static void RectangleStar()
        {
            try
            {
                Console.WriteLine("Please enter the dimension of the rectangle between 1 and 1000 (line then column) example : 2 3");
                string[] inputs = Console.ReadLine().Split();

                //line
                int n = int.Parse(inputs[0]);

                //column
                int m = int.Parse(inputs[1]);

                if (n < 1 || m < 1 || n > 1000 || m > 1000)
                {
                    RectangleStar();
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        int cpt = i % 3;
                        string line = "";
                        for (int j = 1; j <= m; j++)
                        {
                            if ((i == 1 && j == 1) || (i == 1 && j == m) || (i == n && j == 1) || (i == n && j == m))
                                line += "0";
                            else if (i == 1 || i == n)
                                line += "-";
                            else if (j == 1 || j == m)
                                line += "|";
                            else if ((j % 3 == cpt))
                                line += "*";
                            else
                                line += " ";
                        }
                        Console.WriteLine(line);
                    }
                }      
            }
            catch(Exception e)
            {
                RectangleStar();
            }
        }

        private static void ChrismasTree()
        {
            try
            {
                Console.WriteLine("Please enter the size of the tree between 3 and 20");
                string input = Console.ReadLine();

                int n = int.Parse(input);

                if (n < 3 || n > 20)
                {
                    ChrismasTree();
                }
                else
                {
                    int star = 1;
                    int space = n - 1;
                    for (int i = 0; i < n; i++)
                    {
                        string line = "";
                        for (int j = 1; j <= n*2-1; j++)
                        {
                            if(j <= space)
                            {
                                line += " ";
                            }
                            else if(j <= space + star)
                            {

                                    line += "*";          
                            }
                        }
                        star += 2;
                        space -= 1;
                        Console.WriteLine(line);
                    }
                    string str = "";
                    for (int l = 0; l < n - 2; l++)
                    {
                        str += " ";
                    }
                    Console.WriteLine(str + "| |");
                }
            }
            catch (Exception e)
            {
                ChrismasTree();
            }
        }


        private static void ChrismasTreeDecorated()
        {
            try
            {
                Console.WriteLine("Please enter the size of the tree between 3 and 20");
                string input = Console.ReadLine();

                int n = int.Parse(input);

                if (n < 3 || n > 20)
                {
                    ChrismasTreeDecorated();
                }
                else
                {
                    int star = 1;
                    int space = n - 1;
                    for (int i = 0; i < n; i++)
                    {
                        int cpt = (i + 1) % 3;
                        string line = "";
                        for (int j = 1; j <= n * 2 - 1; j++)
                        {
                            if (j <= space)
                            {
                                line += " ";
                            }
                            else if (j <= space + star)
                            {
                                if (j % 3 == cpt)
                                {
                                    Random random = new Random();
                                    int randomInt = random.Next(1, 5);
                                    if(randomInt == 1)
                                    {
                                        line += "o";
                                    }
                                    else
                                    {
                                        line += "i";
                                    }
                                }
                                else
                                {
                                    line += "*";
                                }

                            }
                        }
                        star += 2;
                        space -= 1;
                        Console.WriteLine(line);
                    }
                    string str = "";
                    for (int l = 0; l < n - 2; l++)
                    {
                        str += " ";
                    }
                    Console.WriteLine(str + "| |");
                }
            }
            catch (Exception e)
            {
                ChrismasTreeDecorated();
            }
        }
    }
}
