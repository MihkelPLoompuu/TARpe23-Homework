using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_w7
{
    internal class Linen : Regular
    {
        public override void DoIroning(string program)
        {
            base.DoIroning(program);
        }
        public override void DoIroning(int A)
        {
            base.DoIroning(A);
        }
        public override void Descale()
        {
            base.Descale();
        }
        public override void TurnOff()
        {
            base.TurnOff();
        }
        public override void TurnOn()
        {
            base.TurnOn();
        }
        public override void UseSteam()
        {
            base.UseSteam();
        }
    }
}
