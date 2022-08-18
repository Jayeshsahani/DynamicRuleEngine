using DynamicRuleApp.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRuleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1,"User 1", 45, Profession.other);

            List<IRule> rules = new List<IRule>() { 
                new HealthWorkerRule(),
                new ArmyRule(),
                new CommonPerson()
            };

            new RuleEngine(rules).Execute(user);
            Console.ReadLine();
        }
    }
}
