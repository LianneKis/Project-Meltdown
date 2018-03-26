using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {

    public enum TileType { Dirt, Water, Soil, Irrigated_Soil, Stone, Marsh, Deep_Water, Shallow_Water}

    TileType type = TileType.Dirt;
    LooseObject looseObject;
    InstalledObject installedObject;

    World world;
    int x;
    int y;

    public Tile(World world, int x, int y)
    {
        this.world = world;
        this.x = x;
        this.y = y;
    }
}
