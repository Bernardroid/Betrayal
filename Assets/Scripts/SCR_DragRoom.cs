using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_DragRoom : MonoBehaviour {

    RaycastHit hitInfo;
    public LayerMask floorMask;

    Color highlightColor;
    Color startingColor;

    Renderer renderer;

    bool b_dragLocked;

    public bool b_piecePermaLocked;

    private void Start()
    {
        b_piecePermaLocked = false;

        renderer = GetComponent<Renderer>();
        startingColor = renderer.material.color;
        highlightColor = Color.yellow;

        hitInfo = new RaycastHit();
    }

    //private void OnMouseDown()
    //{
    //    b_dragLocked = false;
    //}

    //private void OnMouseUp()
    //{
    //    b_dragLocked = true;
    //}

    private void OnMouseEnter()
    {
        if (GetComponent<RoomStatus>().isSelected)
            return;

        if (b_piecePermaLocked)
        {
            renderer.material.color = Color.gray;
        }
        else
        {
            renderer.material.color = highlightColor;
        }
    }

    private void OnMouseExit()
    {
        if (GetComponent<RoomStatus>().isSelected)
            return;

        if (GetComponent<SCR_DragRoom>().b_piecePermaLocked)
        {
            renderer.material.color = Color.gray;
        }
        else
        {
            renderer.material.color = startingColor;
        }
    }

    private void OnMouseDrag()
    {
        //if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, floorMask))
        //{
        //    Debug.Log("floor hit!");
        //    if((hitInfo.transform.CompareTag("Floor") || hitInfo.transform.CompareTag("Unit")) && !b_dragLocked && !b_piecePermaLocked)
        //    {
        //        if (hitInfo.transform.GetComponent<Renderer>().material.color == Color.cyan)
        //        {
        //            transform.position = new Vector3(hitInfo.transform.position.x, 1.0f, hitInfo.transform.position.z);
        //        }
        //        GetComponent<SCR_ShowUnitRange>().ShowRange();
        //    }
        //}

        
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, floorMask))
            {
                Debug.Log("floor hit!");
                if (hitInfo.transform.CompareTag("Floor") && GetComponent<RoomStatus>().isSelected && !b_piecePermaLocked)
                {
                    transform.position = new Vector3(hitInfo.transform.position.x, 7.4f, hitInfo.transform.position.z);

                    if (hitInfo.transform.GetComponent<Renderer>().material.color == Color.cyan)
                    {
                        transform.position = new Vector3(hitInfo.transform.position.x, transform.position.y, hitInfo.transform.position.z);
                    }
                    //GetComponent<SCR_ShowUnitRange>().ShowRange();
                }
            }
        }

        if (Input.GetMouseButtonDown(1) && GetComponent<RoomStatus>().isSelected)
        {
            transform.Rotate(new Vector3(0, 0, 90));
            GetComponent<RoomStatus>().openSpaces = RoomStatus.RotateBoolsClockwise(GetComponent<RoomStatus>().openSpaces);
        }
        //if (Input.GetMouseButtonUp(0) && GetComponent<RoomStatus>().isSelected)
        //{
        //    //GetComponent<SCR_ShowUnitRange>().ClearTiles();
        //    b_piecePermaLocked = true;
        //    //GetComponent<SCR_ShowUnitRange>().b_tileSet = false;
        //}
    }
}
