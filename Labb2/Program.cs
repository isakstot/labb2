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
                Console.WriteLine("1. Add family members \n2. Print names of family members \n3. Print total age \n4. Print average age \n0. Exit");
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
                        else {
                            for (int i = 0; i < nOfPeople; i++)
                            {
                                Console.WriteLine(person[i] + " är " + age[i] + " år gammal.");
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
                            CalculateTotal(age);
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
                            CalculateAverage(age);
                        }
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

                /*
                    int totalAge = CalculateTotal(age);
                    double averageAge = CalculateAverage(age);

                    Console.WriteLine($"Sammanlagd ålder: {totalAge}");
                    Console.WriteLine($"Medelålder: {averageAge:F2}");

                */



                int CalculateTotal(int[] ages)
                {
                    int sum = 0;
                    foreach (int age in ages)
                    {
                        sum += age;
                    }
                    return sum;
                }

                double CalculateAverage(int[] ages)
                {
                    double sum = 0;
                    foreach (int age in ages)
                    {
                        sum += age;
                    }
                    sum = sum / ages.Length;
                    return (double)sum;
                }
            }
        }
    }
}