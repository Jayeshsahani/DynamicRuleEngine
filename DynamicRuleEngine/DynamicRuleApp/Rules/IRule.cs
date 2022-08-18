using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRuleApp.Rules
{
    public interface IRule
    {
        bool isApplicable(User user);
        void Execute(User user);

    }
}
