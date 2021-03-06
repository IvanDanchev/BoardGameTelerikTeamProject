﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.UnitClasses
{
    class HordeWarlock : RaceHorde
    {
        //Attack & Health start values
        private const int InitialAttackLevel = 30;
        private const int InitialHealthLevel = 60;

        //Unit constructor
        public HordeWarlock()
        {
            this.UnitType = HordeTypeUnits.Warlock;
            this.AttackLevel = InitialAttackLevel;
            this.HealthLevel = InitialHealthLevel;
        }
    }
}
