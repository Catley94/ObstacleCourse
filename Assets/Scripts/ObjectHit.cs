using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    Color DefaultColour;

    void Start() 
    {
        DefaultColour = GetComponent<MeshRenderer>().material.color;
    }

    private void OnCollisionEnter(Collision other) 
    {
        Debug.Log("The wall is hit");
        if(other.gameObject.tag == "Player") {
            GetComponent<MeshRenderer>().material.color = Color.cyan;
            gameObject.tag = "Hit";
        }
    }

    // private void OnCollisionExit(Collision other) 
    // {
    //     GetComponent<MeshRenderer>().material.color = DefaultColour;
    // }
}
