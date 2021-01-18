﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{

   public enum TileType { Empty, Floor};

    TileType type = TileType.Empty;

    LooseObject looseObject;
    InstalledObject installedObject;

    World world;
    int y;
    int x;

    public TileType Type { get => type; set => type = value; }
    public int Y { get => y;}
    public int X { get => x;}

    public Tile(World world, int x, int y)
    {
        this.world = world;
        this.x = x;
        this.y = y;
    }

}
