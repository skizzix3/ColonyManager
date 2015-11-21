﻿// Manager/Comp_ManagerStation.cs
// 
// Copyright Karel Kroeze, 2015.
// 
// Created 2015-11-04 19:30

using Verse;

namespace FM
{
    internal class Comp_ManagerStation : ThingComp
    {
        // todo add automatic work setup.
        // todo add research and more workstations.
        public CompProperties_ManagerStation Props;

        public override void Initialize( CompProperties vprops )
        {
            base.Initialize( vprops );
            Props = vprops as CompProperties_ManagerStation;
            if ( Props == null )
            {
                Log.Warning( "Props went horribly wrong." );
                Props = new CompProperties_ManagerStation { Speed = 250 };
            }
        }
    }
}