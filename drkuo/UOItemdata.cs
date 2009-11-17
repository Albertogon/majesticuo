﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace drkuo
{
    class uoclientvars
    {
        public int TargCurs;
        public int LTargetID;
        public int LTargetX;
        public int LTargetY;
        // Model must be set to 0 for map/landscape or the type/graphic if its a static tile
        public int LTargetModel;
        public int LTargetZ;

    }
    class uoplayer
    {
        public int tempx;
            public int tempy; // temp movement fix
            public int seq; // temp
    public int CharID;
    public int CharType;
    public int CharPosX;
    public int CharPosY;
    public int CharPosZ;
    public int MaxHits;
    public int MaxMana;
    public int MaxStam;
    public int Hits;
    public int Mana;
    public int Stamina;
    public int Gold;
    public int Weight;
    public int MaxWeight;
    public String CharName;
    public int Sex;
    public int Int;
    public int Str;
    public int Dex;
    public int flags;
    public int hue;
    public int BackpackID;
    public bool WarMode;
    public int Facet;
    public int Direction;

    }
    class uoobject
    {
        public int serial;
        public int type;
        public int x;
        public int y;
        public int z;
        public int color;
        public int stack;
        public int flags;
    }
}
