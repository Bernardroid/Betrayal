using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {

    public static GameObject[,] Tiles;

    public static int width = 10;
    public static int height = 10;

    public static void  ResetTilesColor()
    {
        for(int i = 0; i < Tiles.GetLength(0); i++)
        {
            for(int j = 0; j < Tiles.GetLength(1); j++)
            {
                Tiles[i, j].GetComponent<SCR_FloorTileInfo>().ChangeTileColor(SCR_FloorTileInfo.originalColor);
            }
        }
    }

}
