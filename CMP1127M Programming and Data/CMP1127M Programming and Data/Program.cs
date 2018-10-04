using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1127M_Programming_and_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scott Brown 16653221
            
            //Array of top 15 film weekend gross
            decimal[] filmGrossArray = new decimal[] {458095, 2138824, 1701162, 924424, 517378, 1268401, 1256615, 1234214, 1057211, 910555, 794409, 457323, 389339, 225606, 1502535};

            //Array of top 15 film weekend gross that are only UK/USA
            decimal[] filmUKUSAGrossArray = new decimal[] {2138824, 1701162, 924424, 517378};

            //Weekend gross of Christopher Robin
            decimal christopherRobinGross = 2138824;

            //Weekend gross of Mama Mia
            decimal mamaMiaGross = 1701162;

            //Total for working out average gross
            decimal total = 0;

            //variable to store averge gross
            decimal average;

            //variable to store the ticket price
            decimal ticketPrice = 8;

            //variable to display what number item from the array is being used
            int count = 1;
            
            //iterate through filmGrossArray
            foreach (int i in filmGrossArray)
            {
                //Output current gross
                Console.WriteLine(count + ": " + i);

                //Add current gross to total
                total += i;

                //Add 1 to count
                count++;
            }

            //work out the average for top 15 films
            average = Math.Round (total / filmGrossArray.Length);

            //output the average
            Console.WriteLine("Average Of Top 15 Films: " + average + "\n\n");

            //reset values
            total = 0;
            count = 1;
            average = 0;

            //iterate through filmUKUSAGrossArray
            foreach (int i in filmUKUSAGrossArray)
            {
                //output current gross
                Console.WriteLine(count + ": " + i);

                //add current gross to total
                total += i;

                //add 1 to count
                count++;
            }

            //work out average for only UK/USA films
            average = Math.Round(total / filmUKUSAGrossArray.Length);

            //output average
            Console.WriteLine("Average Of Top 15 UK/USA Films Only: " + average + "\n\n");

            //work out and output how many people viewed christopher robin
            Console.WriteLine("The number of people that viewed Christopher Robin are: " + christopherRobinGross/ticketPrice + "\n\n");

            //Use reverse percentages to work out the weekend gross for the previous week and output them
            Console.WriteLine("Last Week Christopher Robin made: " + Math.Round((christopherRobinGross / 84) * 100));
            Console.WriteLine("Last Week Mama Mia: Here We Go Again made: " + Math.Round((mamaMiaGross / 76) * 100));

            //readline to pause program to be able to read outputs
            Console.ReadLine();



        }
    }
}
