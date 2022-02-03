﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;

namespace WF
{
    public class WaterFreezesSettings : ModSettings
    {
        public static int IceRate = 1000;
        public static float FreezingMultiplier = 4;
        public static float ThawingDivisor = 2;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref IceRate, "IceRate");
            Scribe_Values.Look(ref FreezingMultiplier, "FreezingMultiplier");
            Scribe_Values.Look(ref ThawingDivisor, "ThawingDivisor");

            base.ExposeData();
        }
    }
}