using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRuleApp.Rules
{
    public class RuleEngine
    {
        private IEnumerable<IRule> rules;

        public RuleEngine(IEnumerable<IRule> rules)
        {
            this.rules = rules;
        }

        public void Execute(User user)
        {
            if (rules.Any())
            {
                foreach (var rule in rules)
                {
                    if (rule.isApplicable(user))
                    {
                        rule.Execute(user);
                    }
                }
            }
        }
    }
}
