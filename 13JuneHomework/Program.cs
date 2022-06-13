using System;

namespace _13JuneHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human(21)
            {
                Name = "Mercury",
                Surname = "Planet"
            };

            Human human2 = new Human(12)
            {
                Name = "Jupiter",
                Surname = "Planetzade"
            };

            Human human3 = new Human(89)
            {
                Name = "Venus",
                Surname = "Planetova"
            };

            Human human4 = new Human(12)
            {
                Name = "Mars",
                Surname = "Planetov"
            };
            
            Human human5 = new Human(210)
            {
                Name = "Saturn",
                Surname = "Planetli"
            };

            Human[] humans = new Human[] { human1, human2, human3, human4, human5 };


            Console.Write("Axtaris deyerini daxil edin......");

            string searchQuery;
            do
            {
                searchQuery = Console.ReadLine();

            } while (searchQuery == null);


            string Fullname;
            string FullnameReversed;


            for (int i = 0; i < humans.Length; i++)
            {
                Fullname = humans[i].Surname + " " + humans[i].Name;
                FullnameReversed = humans[i].Name + " " + humans[i].Surname;
                
                if (humans[i].Name.Contains(searchQuery) || humans[i].Surname.Contains(searchQuery)||Fullname.Contains(searchQuery) || FullnameReversed.Contains(searchQuery))
                {
                    Console.WriteLine($"{humans[i].Name} {humans[i].Surname}");
                }

            }


        }
    }
}

