namespace DebuggerImprovements
{
    public class Address
    {
        public string ZipCode { get; set; }
    }
    public class Person
    {
        public Address Address { get; set; }
    }

    public class LocationUtilities
    {
        public static string FindCity(string zipCode)
        {
            return "SomeCity";
        }
    }
}
