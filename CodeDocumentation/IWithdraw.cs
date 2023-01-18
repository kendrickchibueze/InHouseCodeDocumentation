using AttributeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDocumentation
{
    [Document("This is an interface for Withdrawal", Input = "double amount", Output = "bool")]
    internal interface IWithdraw
    {
        bool Withdraw(double amount);
    }
}
