using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_UIManager : MonoBehaviour {

    public GameObject[] rooms;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCreateRoomClicked(int _numberOfDoors)
    {
        Instantiate(rooms[_numberOfDoors]);
    }
}
