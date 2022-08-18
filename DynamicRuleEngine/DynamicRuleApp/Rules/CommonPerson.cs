using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRuleApp.Rules
{
    public class CommonPerson : IRule
    {
        public void Execute(User user)
        {
            Console.WriteLine("Rule for Common Person.");
        }

        public bool isApplicable(User user)
        {
            return user.Age > 40;
        }
    }
}
