using AttributeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDocumentation
{
    [Document("This is an interface for Deposit", Input = "double amount", Output = "none")]
    internal interface IDeposit
    {
        void Deposit(double amount);
    }
}
