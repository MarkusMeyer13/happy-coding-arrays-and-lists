using HappyCoding.ArraysLists.Cmd.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoding.ArraysLists.Cmd
{
    internal class Sample
    {
        internal static void ListSample()
        {
            List<string> names = new List<string>();
            names.Add("Markus");
            names.Add("Lorem");
            names.Add("Ipsum");
            names.Add("Markus");

            if (names.Contains("Markus"))
            {
                names.Remove("Markus");
            }

            Console.WriteLine("Names:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(1);
            numbers.Add(5);

            Console.WriteLine();
            Console.WriteLine("Sum:");
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }

            Console.WriteLine(sum);

            Console.WriteLine();

            ArrayList arrayList = new ArrayList();
            arrayList.Add("a");
            arrayList.Add(1);

            Console.WriteLine("ArrayList:");
            var arrayListEnumerator = arrayList.GetEnumerator();
            while (arrayListEnumerator.MoveNext())
            {
                Console.WriteLine(arrayListEnumerator.Current);
            }
        }

        internal static void DictionarySample()
        {
            HappyCoding.ArraysLists.Cmd.Models.Employee employee = new Models.Employee();
            employee.EMail = "test@plan-b-gmbh.com";

            Dictionary<string, Employee> employees = new Dictionary<string, Employee>();
            employees.Add(employee.EMail, employee);
            employees.Add("markus.meyer@plan-b-gmbh.com", employee);
            employees.Add("lorem.ipsum@plan-b-gmbh.com", employee);

            Dictionary<string, string> dictionary = new()
            {
                { "lorem", "test" },
                { "ipsum", "test" },
            };

            if (dictionary.ContainsKey("ipsum"))
            {
                dictionary["ipsum"] = "test1";
            }

            Console.WriteLine("Dictionary:");
            foreach (KeyValuePair<string, string> item in dictionary)
            {
                Console.WriteLine("key: " + item.Key);
                Console.WriteLine("value: " + item.Value);
            }

        }
    }
}
