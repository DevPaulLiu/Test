using System;
using GoToTestSpace;

namespace GoToTestSpace
{
    public class TestClass
    {
        public void TestingMethod()
        {
            Person person = new Person();

            person.cash = 777;
            bool cheat = person.CheatCash();

            System.Console.Write(cheat);
            System.Console.Write(person.Name);
            System.Console.Write(System.Console.CapsLock);

            if (String.IsNullOrEmpty(person.Name) && (person.Age < 18))
            {
                NullReferenceException ex = new NullReferenceException("Invalid person, incorrect name or age is too old");
                throw ex;
            }
        }
    }
}

