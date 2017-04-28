using System;
using System.Linq;

namespace EditorImprovements
{
    public class CSharp7
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public void Literals()
        {

        }

        public void ParseOut(string numberString)
        {
            int i;
            if (int.TryParse(numberString, out i))
            {
                Number = i;
            }
        }

        public void NullCheck(string name)
        {
            if (name == null)
                throw new ArgumentNullException();
            this.Name = name;
        }

        public void ConditionalSwitch(Person p)
        {
            switch (p)
            {

                default:
                    break;
            }
        }

        public void DemoTuples()
        {
            var names = ParseName();
        }

        public Tuple<string, string> ParseName()
        {
            string[] nameItems = Name.Split(' ');

            var firstName = nameItems.Any() ? nameItems[0] : string.Empty;
            var lastName = nameItems.Count() > 1 ? nameItems[1] : string.Empty;

            return new Tuple<string, string>(firstName, lastName);
        }
    }
}
