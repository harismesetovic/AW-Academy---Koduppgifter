using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien_Attack
{
    public class Alien
    {
        public virtual int Health { get; set; } = 3;
        public virtual int Damage { get; set; } = 5;
    }

    public void Attack()
    {

    }

    public virtual bool CalculateHit()
    {

    }
}
