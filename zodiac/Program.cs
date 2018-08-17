using System;

namespace zodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your birthdate");

            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            string sign = "blank";

            if (birthdate.Month == 1)
            {
                if (birthdate.Day >= 20)
                {
                    sign = "Aquarius";
                }
                else if (birthdate.Day <= 19)
                {
                    sign = "Capricorn";
                }
                else if (birthdate.Month == 2)
                {
                    if (birthdate.Day >= 19)
                    {
                        sign = "Pisces";
                    }
                    else if (birthdate.Day >= 21)
                    {
                        sign = "Aries";
                    }
                }

                string fortune = "blank";

                if (sign == "Aquarius")
                {
                    fortune = "you will be a priest";
                }

                else if (sign == "Capricorn")
                {
                    fortune = "you will get married tomorrow";
                }

                else if (sign == "Pisces")
                {
                    fortune = "you will win lottery today";
                }

                else if (sign == "Aries")
                {
                    fortune = "you will have a baby soon";
                }

                Console.WriteLine("your birthdate is :+birthdate.AddYears(1).Day of the week");
                Console.ReadLine();

                if (sign == "capricorn" || "Pisces")
                {
                    Console.WriteLine("sign");
                    Console.WriteLine)("fortune");
                    Console.ReadLine();
                }
    }

