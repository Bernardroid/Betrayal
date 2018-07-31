using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_SelectRoom : MonoBehaviour {

    RaycastHit hitInfo;

    GameObject[] rooms;

    GameObject roomSelected;

    void Start()
    {
        hitInfo = new RaycastHit();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
            {
                Debug.Log(hitInfo.transform.tag);
                if (hitInfo.transform.CompareTag("Room"))
                {
                    Debug.Log("Room Selected!");
                    DeselectAllRooms();
                    hitInfo.transform.GetComponent<Renderer>().material.color = Color.blue;
                    hitInfo.transform.GetComponent<RoomStatus>().isSelected = true;
                    roomSelected = hitInfo.transform.gameObject;
                }
                else
                {
                    DeselectAllRooms();
                }
            }
            //In case they click outside the board
            else
            {
                DeselectAllRooms();
            }
        }
    }

    void DeselectAllRooms()
    {
        rooms = GameObject.FindGameObjectsWithTag("Room");

        roomSelected = null;
        for (int i = 0; i < rooms.Length; i++)
        {
            rooms[i].GetComponent<RoomStatus>().isSelected = false;
            if (rooms[i].GetComponent<SCR_DragRoom>().b_piecePermaLocked)
            {
                rooms[i].GetComponent<Renderer>().material.color = Color.gray;
            }
            else
            {
                rooms[i].GetComponent<Renderer>().material.color = Color.white;
            }
        }
    }
}
