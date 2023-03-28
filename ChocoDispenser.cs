using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1 - Green
//2 - Red
//3 - Blue
//4 - Orange
//5 - Yellow
//6 - Violet
//7 - Pink
//8 - VIBGYOR
namespace AssessmentMar24
{
    internal class ChocoDispenser
    {
        int[] choco = new int[] { 1, 1, 1, 2, 3, 2, 4, 5, 1, 6, 3, 6, 7 };
        string[] chocoColor = { "green", "red", "blue", "orange", "yellow", "violet", "pink", "VIBGYOR" };
        public void addChocolates()
        {
            Console.WriteLine("The color you want");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c > choco.Length)
            {
                Console.WriteLine("Wrong Input");
            }
            else
            {
                Console.WriteLine("How many");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    choco = choco.Append(c).ToArray();
                }
                foreach (var i in choco)
                {
                    Console.WriteLine(chocoColor[i - 1]);
                }
            }

        }
        public void removeChocolates()
        {
            Console.WriteLine("Remove the excess");
            Console.WriteLine("Count");

            int count = Convert.ToInt32(Console.ReadLine());
            if (count > choco.Length)
            {
                Console.WriteLine("Wrong Input");

            }
            else
            {
                choco = choco.SkipLast(count).ToArray();
                /*for (int i = choco[choco.Length - count]; i < choco.Length; i++)
                {
                    choco = choco.SkipLast(i).ToArray();
                    //choco[i] = '\0';
                }*/
                Console.WriteLine("Present Choco: ");
                foreach (var i in choco)
                {
                    Console.Write(chocoColor[i - 1] + " ");
                }
            }
        }
        public void dispenseChocolates()
        {
            Console.WriteLine("Number of Choco to remove from bottom");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.Write("Removed Elements: ");
            for(int i=0; i<count; i++)
            {
                Console.Write(choco[i] + " ");
                choco = choco.Skip(i).ToArray();
            }

            //for(int i=0; i<count)
            foreach (int i in choco)
            {
                Console.WriteLine(chocoColor[i] + " ");
            }

        }
        public void dispenseChocolatesOfColor()
        {
            Console.Write("Fav Color: ");
            int fav = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Count: ");
            int count = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<count; i++)
            {
                if (choco[i] == fav)
                {
                    Console.WriteLine(choco[i]);
                }
            }

        }
        public void noOfChocolates()
        {
            int c = 1;
            int count = 7;
            Console.Write("[ ");
            for(int i = 0; i < count ; i++)
            {
                
                int num = 1;
                for (int j=0; j < choco.Length ; j++)
                {
                    if (choco[j] == c)
                    {
                        num++;
                    }
                }
                c++;
                Console.Write(+(num-1) + " " + chocoColor[i]);
                
            }
            Console.WriteLine(" ]");
            
        }
        public void sortChocolateBasedOnCount()
        {
            Array.Sort(choco);
            Array.Reverse(choco);
            foreach (int i in choco)
            {
                //Console.Write(i + " ");
                Console.Write(chocoColor[i-1] + " ");
            }

        }
        public void changeChocolateColor()
        {
            Console.Write("Color you want to change: ");
            int change = Convert.ToInt32(Console.ReadLine());

            Console.Write("Change to: ");
            int changeTo = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < choco.Length ; i++)
            {
                if (change == choco[i])
                {
                    choco[i] = changeTo;
                }
            }
            foreach (int i in choco)
            {
                Console.Write(chocoColor[i - 1] + " ");
            }
        }
        public void changeChocolateAllOfxCount()
        {
            Console.Write("Color you want to change: ");
            int change = Convert.ToInt32(Console.ReadLine());

            Console.Write("Change to: ");
            int changeTo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Count: ");
            int count = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i < count ;i++)
            {
                if (choco[i] == change)
                {
                    choco[i] = changeTo;
                }
            }
            for(int i = 0; i < count; i++)
            {
                Console.Write(chocoColor[i] + " ");
            }


        }
        public void removeChocolateOfColor()
        {
            Console.Write("Enter the color to remove: ");
            int rem = Convert.ToInt32(Console.ReadLine());

            choco = choco.Where(r => r != rem).ToArray();
            
            foreach (int i in choco)
            {
                Console.Write(chocoColor[i - 1] + " ");
            }
        }
        public void dispenseRainbowChocolates()
        {
            //List<int> chocoList = choco.ToList();
            int g = 0, r = 0, b = 0, o = 0, y = 0;
            int[] vibgyor = new int[] {};
            for(int i=0; i < choco.Length;i++)
            {
                if (choco[i] == 1)
                {
                    //vibgyor = vibgyor.Append(choco[i]).ToArray();
                    g++;
                    if (g == 3) 
                    {
                        vibgyor = vibgyor.Append(8).ToArray();
                    }
                }
                else if (choco[i] == 2)
                {
                    r++;
                    if (r == 3)
                    {
                        vibgyor = vibgyor.Append(8).ToArray();
                    }
                }
                else if (choco[i] == 3)
                {
                    b++;
                    if (b == 3)
                    {
                        vibgyor = vibgyor.Append(8).ToArray();
                    }
                }
                else if (choco[i] == 4)
                {
                    o++;
                    if (o == 3)
                    {
                        vibgyor = vibgyor.Append(8).ToArray();
                    }
                }
                else if (choco[i] == 5)
                {
                    y++;
                    if (y == 3)
                    {
                        vibgyor = vibgyor.Append(8).ToArray();
                    }
                }
                else
                {
                    vibgyor = vibgyor.Append(choco[i]).ToArray();
                }
            }
            foreach(var i in vibgyor)
            {
                Console.Write(chocoColor[i - 1] + " ");
            }

        }
        static void Main(string[] arg)
        {
            var obj = new ChocoDispenser();
            Console.WriteLine("Hello !\n The Chocolate Colors are: ");
            Console.WriteLine("1 - Green\n2 - Red\n3 - Blue\n4 - Orange\n5 - Yellow\n6 - Violet\n7 - Pink\n8 - VIGBYOR");
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