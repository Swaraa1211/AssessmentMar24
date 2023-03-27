namespace AssessmentMar24
{
    internal class PersonalityTraitApp
    {
        public void BeAMentalist()
        {
            Console.WriteLine("Be a Mentalist Game!");
            Console.WriteLine("Ans few questions: \n 1. Agree\n 2. Neither Agree Nor Disgree\n 3. Disagree");
            string[] qn = new string[3] { "Qn 1. I almost complete what I started", "Qn 2. I can handle myself well in crisis", "Qn 3. I seldom pay much attention to my feelings of the moment" };
            int chance = 0, c1 = 0, c2 = 0, c3 = 0;
            while (chance < 3)
            {
                Console.WriteLine(qn[chance]);
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    c1++;
                }
                else if (n == 2)
                {
                    c2++;
                }
                else if (n == 3)
                {
                    c3++;
                }
                else
                {
                    Console.WriteLine("Wrong Answer, Chance Got Over");
                }
                chance++;
            }
            if (c1 > c2 && c1 > c3)
            {
                Console.WriteLine("Optimist & Professtional Person");
            }
            else if (c2 > c3 && c2 > c1)
            {
                Console.WriteLine("Normal Person");
            }
            else
            {
                Console.WriteLine("No Comments");
            }
            Console.WriteLine("Your BE A MENTALIST Session Got Over");

        }
        public void MimicPtolemy()
        {
            Console.WriteLine("MimimPtolemy");
            Console.Write("Your birth month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("Your zodiac is: \"Aries\" & Funny Partner is : Bugs Bunny");
                    break;
                case 2:
                    Console.WriteLine("Your zodiac is: \"Taurus\"& Funny Partner is : Scooby-Doo");
                    break;
                case 3:
                    Console.WriteLine("Your zodiac is: \"Gemini\"& Funny Partner is : SpongeBob");
                    break;
                case 4:
                    Console.WriteLine("Your zodiac is: \"Cancer\"& Funny Partner is : Daffy Duck");
                    break;
                case 5:
                    Console.WriteLine("Your zodiac is: \"Leo\"& Funny Partner is : Tom Cat");
                    break;
                case 6:
                    Console.WriteLine("Your zodiac is: \"Virgo\"& Funny Partner is : Mickey Mouse");
                    break;
                case 7:
                    Console.WriteLine("Your zodiac is: \"Libra\"& Funny Partner is : Jerry Mouse");
                    break;
                case 9:
                    Console.WriteLine("Your zodiac is: \"Scorpio\"& Funny Partner is : Snoopy");
                    break;
                case 10:
                    Console.WriteLine("Your zodiac is: \"Sagittarius\"& Funny Partner is : Pooh");
                    break;
                case 11:
                    Console.WriteLine("Your zodiac is: \"Capricorn\"& Funny Partner is : Donald Duck");
                    break;
                case 12:
                    Console.WriteLine("Your zodiac is: \"Pisces\"& Funny Partner is : Chhota Bheem");
                    break;
                default:
                    Console.WriteLine("specify the correct value");
                    break;
            }
            Console.WriteLine("Your MIMIC PTOLEMY Session Got Over");
        }
        public void CalendarMan()
        {
            Console.WriteLine("Calender Man !");
            Console.WriteLine("Year of Birth");
            int y = Convert.ToInt32(Console.ReadLine());
            int age, pyear = 2023, pmonth = 3;
            age = pyear - y;
            Console.WriteLine("Your Age: " + age);
            Console.WriteLine("Birth Month ");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m > pmonth)
            {
                Console.WriteLine("Your Birthday is " + (m - pmonth) + "Months Away");
            }
            else
            {
                Console.WriteLine("Your Birthday is " + (pmonth - m) + "Months Away");
            }
            Console.WriteLine("Your CALENDAR MAN Session Got Over");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome!\n Name");

            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);
            PersonalityTraitApp app = new PersonalityTraitApp();
            app.BeAMentalist();
            app.MimicPtolemy();
            app.CalendarMan();
        }
    }
}