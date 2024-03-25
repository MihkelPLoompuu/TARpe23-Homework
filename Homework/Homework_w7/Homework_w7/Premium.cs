using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_w7
{
    internal class Premium : Regular
    {
        public override void DoIroning(int A)
        {
            base.DoIroning(A);
        }
        public override void DoIroning(string program)
        {
            base.DoIroning(program);
        }
        public override void UseSteam()
        {
            base.UseSteam();
        }
        public override void TurnOff()
        {
            base.TurnOff();
        }
        public override void TurnOn() 
        { 
            base.TurnOn();
        }
    }
}
