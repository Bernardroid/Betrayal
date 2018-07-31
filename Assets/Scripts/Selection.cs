using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    RaycastHit hit;
    Ray myRay;
    Transform Lastobject;
    public GameObject prefab;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(myRay, out hit, 100.0f))
            {
                if (hit.transform.CompareTag("Room"))
                {
                    if(Lastobject != null)
                    {
                        //Lastobject.GetComponent<Room>().ChangeStrenght(0.0f);
                        Lastobject.GetComponent<Green>().deseleccionado();
                    }   
                    Lastobject = hit.transform;
                    //Lastobject.GetComponent<Room>().ChangeStrenght(0.5f);
                    Lastobject.GetComponent<Green>().seleccionado();
                    Debug.Log("You selected the " + hit.transform.name);
                }
                if(hit.transform.CompareTag("Green"))
                {
                    Instantiate(prefab, hit.transform.position,Quaternion.identity);
                }
            }
        }
    }

    void Seleccionado()
    {

    }
}
