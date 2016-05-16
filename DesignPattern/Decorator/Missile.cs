using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class  Missile : Tank
    {
        private readonly Tank _tank;
        public Missile(Tank t)
        {
            this._tank = t;
        }

        public void ChangeWeapon()
        {
            this._tank.Weapon = "Missile";
        }
        public override void Show()
        {
           Console.Write(this._tank.Weapon);
        }
    }
}
