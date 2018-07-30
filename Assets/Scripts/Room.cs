using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    
    public GameObject FrontOpen;
    public GameObject LeftOpen;
    public GameObject BackOpen;
    public GameObject RightOpen;

    public GameObject FrontClose;
    public GameObject LeftClose;
    public GameObject BackClose;
    public GameObject RightClose;

    public GameObject FrontOpen1;
    public GameObject FrontOpen2;
    public GameObject LeftOpen1;
    public GameObject LeftOpen2;
    public GameObject BackOpen1;
    public GameObject BackOpen2;
    public GameObject RightOpen1;
    public GameObject RightOpen2;

    public float strenght;

    Material[] myMat = new Material[13];

    // Use this for initialization
    void Start () {

        myMat[0]  = this.GetComponent<MeshRenderer>().materials[0];
        myMat[1]  = FrontClose.GetComponent<MeshRenderer>().materials[0];
        myMat[2]  = LeftClose.GetComponent<MeshRenderer>().materials[0];
        myMat[3]  = BackClose.GetComponent<MeshRenderer>().materials[0];
        myMat[4]  = RightClose.GetComponent<MeshRenderer>().materials[0];
        myMat[5]  = FrontOpen1.GetComponent<MeshRenderer>().materials[0];
        myMat[6]  = FrontOpen2.GetComponent<MeshRenderer>().materials[0];
        myMat[7]  = LeftOpen1.GetComponent<MeshRenderer>().materials[0];
        myMat[8]  = LeftOpen2.GetComponent<MeshRenderer>().materials[0];
        myMat[9]  = BackOpen1.GetComponent<MeshRenderer>().materials[0];
        myMat[10] = BackOpen2.GetComponent<MeshRenderer>().materials[0];
        myMat[11] = RightOpen1.GetComponent<MeshRenderer>().materials[0];
        myMat[12] = RightOpen2.GetComponent<MeshRenderer>().materials[0];

        //myMat.shader = Shader.Find("SF_Tron");
    }
	
	// Update is called once per frame
	void Update ()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("entro");
        //    ChangeStrenght(0.5f);
        //}
    }

    public void ChangeStrenght(float _value)
    {
        for(int i = 0; i < myMat.Length;i++)
        {
            myMat[i].SetFloat("_Strenght", _value);
        }
        
    }
}
