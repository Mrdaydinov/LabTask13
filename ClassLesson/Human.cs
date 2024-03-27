using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{
    internal class Human
    {
        public string Name;
        public string Surname;
        public int Age;
        public string City;

        public Human(string name, string surname, int age, string city)
        {
            Name = name;
            Surname = surname;
            Age = age;
            City = city;
        }

        public bool IsStudent()
        {
            if (Age >= 18 && Age <= 25)
                return true;
            else
                return false;
        }

        public void CheckCity(string city)
        {
            if (City == city)
                Console.WriteLine("Eyni sheherdir");
            else
                Console.WriteLine("Deyil");
        }

        public void CheckCity2(string[] cities)
        {
            foreach (string city in cities)
            {
                if (City == city)
                    Console.WriteLine("Eyni sheherdir");
                else
                    Console.WriteLine("Deyil");
            }
        }

        public void CheckCity2(Human[] humans)
        {
            foreach (Human human in humans)
            {
                if (human == this)
                    continue;
                else if (human.City == City)
                    Console.WriteLine("Eyni sheherdir");
                else
                    Console.WriteLine("Deyil");
            }
        }

        public void GetCount(Human[] humans)
        {
            Human[] newHumans = new Human[humans.Length];

            for (int i = 0; i < humans.Length; i++)
            {
                int count = 0;
                if (humans[i].IsStudent())
                {
                    for (int j = 0; j < humans.Length; j++)
                    {
                        if (humans[j].IsStudent())
                        {
                            if (humans[i].City == humans[j].City)
                            {
                                count++;

                            }
                        }
                    }
                }

                if (!(count == 0))
                    Console.WriteLine($"count = {count}, city = {humans[i].City}");
            }
        }
    }
}
