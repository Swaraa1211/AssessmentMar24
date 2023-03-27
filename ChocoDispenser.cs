using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentMar24
{
    internal class ChocoDispenser
    {
        int[] choco = { 1, 1, 1, 2, 3, 2, 4, 5, 1, 6, 3, 6, 7 };
        public void addChocolates()
        {
            Console.WriteLine("The color you want");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                choco.Append(c);
            }
            foreach (int i in choco)
            {
                Console.WriteLine(i);
            }

        }
        public void removeChocolates()
        {
            Console.WriteLine("Remove the excess");
            Console.WriteLine("Count");

            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = choco[count]; i < choco.Length; i++)
            {
                choco[i] = '\0';
            }
            Console.WriteLine("Present content");
            foreach (int i in choco)
            {
                Console.WriteLine(i + " ");
            }
        }
        public void dispenseChocolates()
        {


        }
        public void dispenseChocolatesOfColor()
        {

        }
        public void noOfChocolates()
        {

        }
        public void sortChocolateBasedOnCount()
        {

        }
        public void changeChocolateColor()
        {

        }
        public void changeChocolateAllOfxCount()
        {

        }
        public void removeChocolateOfColor()
        {

        }
        public void dispenseRainbowChocolates()
        {

        }
        static void Main(string[] arg)
        {
            var obj = new ChocoDispenser();
            Console.WriteLine("Hello !\n The Chocolate Colors are: ");
            Console.WriteLine("1 - Green\n2 - Red\n3 - Blue\n4 - Orange\n5 - Yellow\n6 - Violet\n7 - Pink");
            //int[] choco = {1, 1, 1, 2, 3, 2, 4, 5, 1, 6, 3, 6, 7};

            Console.WriteLine("1. Add Choclate");
            Console.WriteLine("2. Remove Chocolate");
            Console.WriteLine("3. Dispense Chocolate");
            Console.WriteLine("4. Fav Chocolate");
            Console.WriteLine("5. Number of Chocos");
            Console.WriteLine("6. Sorting Based on Count");
            Console.WriteLine("7. Change the Color");
            Console.WriteLine("8. Changing the Color & Displayinh the Count");
            Console.WriteLine("9. Fresh Pickings");
            Console.WriteLine("10. Rainows & Sunshine");

            Console.WriteLine("\nYour Choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("MORE! MORE! MORE!");
                    obj.addChocolates();
                    break;
                case 2:
                    Console.WriteLine("LESS! LESS! LESS");
                    obj.removeChocolates();
                    break;
                case 3:
                    Console.WriteLine("One is not enough");
                    obj.dispenseChocolates();
                    break;
                case 4:
                    Console.WriteLine("My favourite color is...");
                    obj.dispenseChocolatesOfColor();
                    break;
                case 5:
                    Console.WriteLine("LED my chocos");
                    obj.noOfChocolates();
                    break;
                case 6:
                    Console.WriteLine("Let's stack em up");
                    obj.sortChocolateBasedOnCount();
                    break;
                case 7:
                    Console.WriteLine("They taste the same!");
                    obj.changeChocolateColor();
                    break;
                case 8:
                    Console.WriteLine("Convert heretics!");
                    obj.changeChocolateAllOfxCount();
                    break;
                case 9:
                    Console.WriteLine("Challenge 1: Fresh Pickings!");
                    obj.removeChocolateOfColor();
                    break;
                case 10:
                    Console.WriteLine("Challenge 2: Rainows & Sunshine!");
                    obj.dispenseRainbowChocolates();
                    break;
                default:
                    Console.WriteLine("Put of Range!");
                    break;

            }
        }
    }
}

//1 - Green
//2 - Red
//3 - Blue
//4 - Orange
//5 - Yellow
//6 - Violet
//7 - Pink