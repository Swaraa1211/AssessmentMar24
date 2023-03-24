namespace AssessmentMar24
{
    internal class PersonalityTraitApp
    {
        public void BeAMentalist()
        {
            Console.WriteLine("Ans few questions: \n 1. Agree\n 2. Neither Agree Nor Disgree\n 3. Disagree");
            string[] qn = new string[3] { "Qn 1. I almost complete what I started", "Qn 2. I can handle myself well in crisis", "Qn 3. I seldom pay much attention to my feelings of the moment" };
            int chance = 1, c1 = 0, c2 = 0, c3 = 0;
            while (chance <= 3)
            {
                Console.WriteLine(qn[chance]);
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    c1++;
                }
                else if(n == 2)
                {
                    c2++;
                }
                else
                {
                    c3++;
                }
                chance++;
            }
            if(c1 > c2 && c1 > c3)
            {
                Console.WriteLine("Optimist & Professtional Person");
            }
            else
            {
                Console.WriteLine("Normal Person");
            }
            Console.WriteLine("Your BE A MENTALIST Session Got Over");

        }
        public void MimicPtolemy()
        {

        }
        public void CalendarMan()
        {
            Console.WriteLine("Year of Birth");
            int y = Convert.ToInt32(Console.ReadLine());
            int age, pyear = 2023, pmonth = 3;
            age = pyear - y;
            Console.WriteLine("Your Age: " + age);
            Console.WriteLine("Birth Month ");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m > pmonth)
            {
                Console.WriteLine("Your Birthday is " + (m - pmonth) + "Away");
            }
            else
            {
                Console.WriteLine("Your Birthday is " + (pmonth - m) + "Away");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome!\n Name");
            
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);
            PersonalityTraitApp app = new PersonalityTraitApp();
            app.BeAMentalist();
        }
    }
}