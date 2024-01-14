using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("1", "Dmytro Leskiv");       // Add 1 person to hash table
            ht.Add("2", "Andriy Guk");          // Add 2 person to hash table
            ht.Add("3", "Danylo Garbich");      // Add 3 person to hash table
            ht.Add("4", "Bohdan Sadovskiy");    // Add 4 person to hash table
            ht.Add("5", "Trygub Maks");         // Add 5 person to hash table

            if (ht.ContainsValue("Bohdan Sadovskiy")) // if this person is in hash table
            {
                Console.WriteLine("This Person is in hash table\n"); // Print message if true
            } else
            {
                ht.Add("6", "Bohdan Sadovskiy");    // if false Add the Person to hash table 
            }

            ICollection key = ht.Keys; // Get keys from hash table

            Console.WriteLine("People in hash table:");
            foreach (string k in key) // This loop is for Printing all people in hash table
                                      // but in a different order
            {
                Console.WriteLine($"  {k}: {ht[k]}"); // Print the person by key
            }
        }
    }
}