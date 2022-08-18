namespace DynamicRuleApp.Rules
{
    public class User
    {
        public User(int id, string name, int age, Profession profession)
        {
            Id = id;
            Name = name;
            Age = age;
            Profession = profession;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Profession Profession { get; set; }
    }

    public enum Profession
    {
        Army,
        HealthWorker,
        other
    }
}