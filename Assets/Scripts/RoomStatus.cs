using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomStatus : MonoBehaviour {

    public bool isSelected;

    //Room info as to which spaces are open starting from top and going clockwise
    public bool[] openSpaces = new bool[4];

    //Change room info if it rotates clockwise
    public static bool[] RotateBoolsClockwise(bool[] _roomInfo)
    {
        bool[] tempBoolArray = new bool[4];

        tempBoolArray[0] = _roomInfo[3];
        for (int i = 1; i <= 3; i++)
        {
            tempBoolArray[i] = _roomInfo[i - 1];
        }

        return tempBoolArray;
    }

    //Change room info if it rotates counterclockwise
    public static bool[] RotateBoolsCounterClockwise(bool[] _roomInfo)
    {
        bool[] tempBoolArray = new bool[4];

        tempBoolArray[3] = _roomInfo[0];
        for (int i = 0; i <= 2; i++)
        {
            tempBoolArray[i] = _roomInfo[i + 1];
        }

        return tempBoolArray;
    }

}
