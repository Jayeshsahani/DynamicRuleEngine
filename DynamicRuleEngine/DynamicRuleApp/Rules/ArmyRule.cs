using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRuleApp.Rules
{
    public class ArmyRule : IRule
    {
        public void Execute(User user)
        {
            Console.WriteLine("Rule for Army.");
        }

        public bool isApplicable(User user)
        {
            return user.Profession == Profession.Army;
        }
    }
}
