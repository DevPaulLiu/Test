using System;

namespace GoToTestSpace
{
    public class Person
    {
        private int age;
        private string name;
        public int cash;

        public Person()
        {
            age = 18;
            name = "N/A";
            cash = 0;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            cash = 0;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public bool CheatCash()
        {
            if (this.cash == 0)
                return false;
            else
            {
                this.cash *= 10;
                return true;
            }
        }

        public void PrintPerson()
        {
            Console.WriteLine("{0}, {1} years old.", name, age);
        }
    }
}