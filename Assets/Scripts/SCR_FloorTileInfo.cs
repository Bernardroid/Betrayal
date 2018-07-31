using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_FloorTileInfo : MonoBehaviour {

    public int xPos;
    public int yPos;

    public bool walkable;

    public static Color originalColor = Color.white;

    public void ChangeTileColor(Color _newColor)
    {
        GetComponent<Renderer>().material.color = _newColor;
    }

}
