using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.interfaces
{
    public interface IWeapon
    {

        int AttackPoints { get; }
        int DurabilityPoints { get; }
        void Attack(ITarget target);

    }
}
