using System;
using System.Collections.Generic;
using System.IO;

namespace EditorImprovements
{
    public class Person
    {
        public Int32 Age { get; internal set; }
        public string Name { get; internal set; }
        public string Phone { get; internal set; }
        public string Address { get; internal set; }
        public string ZipCode { get; internal set; }
        public string City { get; internal set; }
        public void SaveAddressToFile()
        {
            List<string> addressLines = new List<string>
            {
                Name,
                Address,
                $"{ZipCode} {City}"
            };

            string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter($"{myDocPath}\\Address_For_{Name}.txt"))
            {
                foreach (string line in addressLines)
                {
                    outputFile.WriteLine(line);
                }
            }
        }
    }
    public class Customer : Person { }
    public class Employee : Person { }
}
