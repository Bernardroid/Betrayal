using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour
{

    public GameObject[] floors;
    public Room myRoom;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void seleccionado()
    {
        floors[0].SetActive(myRoom.FrontOpen.activeSelf);
        floors[1].SetActive(myRoom.RightOpen.activeSelf);
        floors[2].SetActive(myRoom.BackOpen.activeSelf);
        floors[3].SetActive(myRoom.LeftOpen.activeSelf);
    }
    public void deseleccionado()
    {
        floors[0].SetActive(false);
        floors[1].SetActive(false);
        floors[2].SetActive(false);
        floors[3].SetActive(false);
    }
}
