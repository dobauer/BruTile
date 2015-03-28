﻿// Copyright (c) BruTile developers team. All rights reserved. See License.txt in the project root for license information.

using System;

namespace BruTile.Predefined
{
    [Obsolete("Use GlobalSphericalMercator instead", true)]
    public class SphericalMercatorInvertedWorldSchema : SphericalMercatorWorldSchema
    {
        public SphericalMercatorInvertedWorldSchema() 
        {
            YAxis = YAxis.OSM;
            OriginY = -OriginY; 
            Name = "WorldSphericalMercatorInverted";
        }
    }
}
