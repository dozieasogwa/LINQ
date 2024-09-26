using System.Collections;

namespace LINQ
{
    public class Person
    {
        public string? name;
        public int? age;
        public string? firstName;
        public string? lastName;
    }
    internal class Program
    {

        static void Main(string[] args)
        {
           
            List<Person> people = new()
            { 
                new() { name = "John", age = 25 },
                new() { name = "Sarah", age = 23 },
                new() { name = "Daisy", age = 24 },
                new() { name = "Eze", age = 30 },
                new() { name = "Ofor", age = 20 }
                };

            var oldestPersons = people.FindAll(oldPerson => oldPerson.age > 24);

            people.Reverse();

            IOrderedEnumerable<Person> orderedNames = people.OrderBy(x => x.name).ThenBy(x => x.age);
            IOrderedEnumerable<Person> decendingOrder = people.OrderByDescending(x => x.name);

            foreach (var person in oldestPersons)
            {
               // Console.WriteLine(person.name);
            }

            var oldestAge = people.Select(x => x.age).Max();
           // Console.WriteLine(oldestAge);

            List<int> collection = new() { 1, 2, 3 };
            IEnumerable<float> collectionCast = collection.Cast<float>();

            List<List<int>> newCollection = new()
            {
                new() { 1, 2, 3},
                new() { 4, 5, 6},
                new() {6, 7, 8}
            };

            var listCollection = newCollection.SelectMany(list => list);
            //Console.WriteLine(listCollection);
            //Console.WriteLine(listCollection.Count());
            foreach ( var i in listCollection)
            {
               // Console.Write(i.ToString() + " ");
            }
            Console.WriteLine(string.Empty);


            
            List<int> intArrays = new() { 1, 2, 3, 4, 5, 6 };
            IEnumerable<int> intArray = intArrays.Where(x => x > 3);

            ArrayList array = new() { 1, "D", 2, "N", 3, "A" };
            IEnumerable<string> stringArray = array.OfType<string>();
          
            foreach ( var i in stringArray)
            {
                //Console.Write(i.ToString() + " ");
            }

            List<Person> names = new()
            {
                new() {firstName = "John", lastName = "Eze"},
                new() {firstName = "Micheal", lastName = "Wale"},
                new() {firstName = "joy", lastName = "Eze"},
                new() {firstName = "Blessing", lastName = "Wale"}
            };

            IEnumerable<IGrouping<string, Person>> groupings = names.GroupBy(Person => Person.lastName);
            foreach(var person in groupings)
            {
                Console.WriteLine("Key: " + person.Key);

                foreach (var grouping in person)
                {
                    Console.WriteLine($"\t{grouping.lastName}, {grouping.firstName}");
                }
            }

            List<int> num1 = new() { 1, 2, 3, 4, 5 };
            List<int> num2 = new() { 3, 5, 6, 7, 8 };

            
            IEnumerable<int> num3 = num1.Union(num2);
            IEnumerable<int> num4 = num1.Intersect(num3);
            IEnumerable<int> num5 = num1.Except(num2);
            IEnumerable<int> num6 = num1.Distinct();

            IEnumerable<int> numSkip = num1.Skip(2);
            IEnumerable<int> numTake = num1.Take(3);
            
         

        }
    }
}
