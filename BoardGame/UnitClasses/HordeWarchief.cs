﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.UnitClasses
{
    class HordeWarchief : RaceHorde
    {
        //Attack & Health start values
        private const int InitialAttackLevel = 40;
        private const int InitialHealthLevel = 100;

        //Unit constructor
        public HordeWarchief()
        {
            this.UnitType = HordeTypeUnits.Warchief;
            this.AttackLevel = InitialAttackLevel;
            this.HealthLevel = InitialHealthLevel;
        }
        
    }
}
