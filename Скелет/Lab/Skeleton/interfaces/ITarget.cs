﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.interfaces
{
   public interface ITarget
    {
        int Health { get; }
        void TakeAttack(int attackPoints);
        int GiveExperience();
        bool IsDead();



    }
}
