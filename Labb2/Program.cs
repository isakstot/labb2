using System.ComponentModel.Design;

namespace Labb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int nOfPeople = 1;
            // initializes arrays here so they can be used in cases other than 1
            string[] person = null;
            int[] age = null;

            while (running)
            {
                Console.WriteLine("Pick an option: \n 1. Add family members \n 2. Print names of family members \n 3. Print total age \n 4. Print average age \n 0. Exit");
                string menuOption = Console.ReadLine();
                switch (menuOption)
                {
                    case "1":

                        Console.WriteLine("How many people do you want to add?");
                        nOfPeople = Int32.Parse(Console.ReadLine());
                        person = new string[nOfPeople];
                        age = new int[nOfPeople];

                        for (int i = 0; i < nOfPeople; i++)
                        {
                            Console.Write("Skriv namnet på person " + (i + 1) + ": ");
                            person[i] = Console.ReadLine();
                            Console.Write("Skriv åldern på person " + (i + 1) + ": ");
                            age[i] = Int32.Parse(Console.ReadLine());
                        }

                        break;
                    case "2":
                        if (person == null || age == null)
                        {
                            Console.WriteLine("You have not created added any family members");
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < nOfPeople; i++)
                            {
                                Console.WriteLine(person[i] + " is " + age[i] + " years old.");
                            }
                        }
                        break;
                    case "3":
                        if (person == null || age == null)
                        {
                            Console.WriteLine("You have not created added any family members");
                            break;
                        }
                        else
                        {
                            int totalAge = CalculateTotal(age);
                            Console.WriteLine($"Total age of all family members: {totalAge}");
                        }
                        break;
                    case "4":
                        if (person == null || age == null)
                        {
                            Console.WriteLine("You have not created added any family members");
                            break;
                        }
                        else
                        {
                            double averageAge = CalculateAverage(age);
                            Console.WriteLine($"Average age of all family members: {averageAge:F2}");
                        }
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                //adds empty line after printing
                Console.WriteLine("");
            }


            int CalculateTotal(int[] ages)
            {
                int sum = 0;
                for (int i = 0; i < nOfPeople; i++) {
                    sum += ages[i];
                }
                return sum;
            }

            double CalculateAverage(int[] ages)
            {
                double sum = 0;
                for (int i = 0; i < nOfPeople; i++)
                {
                    sum += ages[i];
                }
                sum = sum / nOfPeople;
                return sum;
            }
        }
    }
}