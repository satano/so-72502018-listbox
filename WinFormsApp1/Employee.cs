namespace WinFormsApp1
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Info => $"{Id} - {LastName} {Name}";
    }
}
