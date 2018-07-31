using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RoomStatus))]
public class SCR_RoomAdjacentLogic : MonoBehaviour
{
    RoomStatus myRoomStats;
    public LayerMask floorMask;

    private void Start()
    {
        myRoomStats = GetComponent<RoomStatus>();
    }

    //Changes colors of neighboring tiles if a space is open
    void CheckAdjacentTiles()
    {
        //Check tile underneath
        Vector2 tileUnder = CheckTileUnderneath();

        //Test: change tile underneath to green (Success)
        //Board.Tiles[(int)tileUnder.x, (int)tileUnder.y].GetComponent<SCR_FloorTileInfo>().ChangeTileColor(Color.green);

        //Test: Change Tiles in an cross around the piece (Success)
        //for(int i = -1; i <= 1; i++)
        //{
        //    for(int j = -1; j <= 1; j++)
        //    {
        //        Board.Tiles[(int)tileUnder.x + i, (int)tileUnder.y].GetComponent<SCR_FloorTileInfo>().ChangeTileColor(Color.green);
        //        Board.Tiles[(int)tileUnder.x, (int)tileUnder.y + j].GetComponent<SCR_FloorTileInfo>().ChangeTileColor(Color.green);
        //    }
        //}

        //Test: Change Tiles in a cross around the piece but only if they have a door
        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                //Check UP tile
                if (j == 1 && myRoomStats.openSpaces[0] && tileUnder.y + 1 >= 0 && tileUnder.y + 1 < Board.Tiles.GetLength(1))
                {
                    Board.Tiles[(int)tileUnder.x, (int)tileUnder.y + j].GetComponent<SCR_FloorTileInfo>().ChangeTileColor(Color.green);
                }

                //Check RIGHT tile
                if(i == 1 && myRoomStats.openSpaces[1] && tileUnder.x + 1 >= 0 && tileUnder.x + 1 < Board.Tiles.GetLength(0))
                {
                    Board.Tiles[(int)tileUnder.x + i, (int)tileUnder.y].GetComponent<SCR_FloorTileInfo>().ChangeTileColor(Color.green);
                }

                //Check DOWN tile
                if(j == -1 && myRoomStats.openSpaces[2] && tileUnder.y - 1 >= 0 && tileUnder.y - 1 < Board.Tiles.GetLength(1))
                {
                    Board.Tiles[(int)tileUnder.x, (int)tileUnder.y + j].GetComponent<SCR_FloorTileInfo>().ChangeTileColor(Color.green);
                }

                //Check LEFT tile
                if(i == -1 && myRoomStats.openSpaces[3] && tileUnder.x - 1 >= 0 && tileUnder.x - 1 < Board.Tiles.GetLength(0))
                {
                    Board.Tiles[(int)tileUnder.x + i, (int)tileUnder.y].GetComponent<SCR_FloorTileInfo>().ChangeTileColor(Color.green);
                }


            }
        }

    }

    

    //Checks position in array of tile underneath room
    public Vector2 CheckTileUnderneath()
    {
        Vector2 tileBelow = new Vector2();
        RaycastHit hitInfo = new RaycastHit();

        Debug.DrawRay(transform.position, Vector3.down, Color.red, 3.0f);

        //Cast ray beneath room to check which tile it's on
        if (Physics.Raycast(transform.position, Vector3.down, out hitInfo, 10.0f, floorMask))
        {
            if (hitInfo.transform.CompareTag("Floor"))
            {
                Debug.Log("Piece is above tile: (" + hitInfo.transform.GetComponent<SCR_FloorTileInfo>().xPos + "," + hitInfo.transform.GetComponent<SCR_FloorTileInfo>().yPos + ")");
                tileBelow = new Vector2(hitInfo.transform.GetComponent<SCR_FloorTileInfo>().xPos, hitInfo.transform.GetComponent<SCR_FloorTileInfo>().yPos);
            }
        }

        return tileBelow;
    }

    //Test
    private void Update()
    {

        if(GetComponent<SCR_DragRoom>().b_piecePermaLocked)
        {
            CheckAdjacentTiles();
        }
        //if (Input.GetKey(KeyCode.Return))
        //{
        //    CheckAdjacentTiles();
        //}
        //if(Input.GetKeyUp(KeyCode.Return))
        //{
        //    Board.ResetTilesColor();
        //}
    }

    public void AddRoomToFloor()
    {
        //Add room using tilebelow to the first floor array
        Vector2 tileBelow = CheckTileUnderneath();
        FirstFloor.floor[(int)tileBelow.x, (int)tileBelow.y].status = GetComponent<RoomStatus>();
        FirstFloor.floor[(int)tileBelow.x, (int)tileBelow.y].inUse = true;
    }

}
