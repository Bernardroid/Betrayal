using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFloor : MonoBehaviour {

    public struct rooms
    {
        public RoomStatus status;
        public bool inUse;
    }

	public static rooms[,] floor = new rooms[10,10]; 

}
