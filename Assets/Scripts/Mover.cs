using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        // transform.Translate(1,0,0);
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions() 
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Use 'W' to move forward");
        Debug.Log("Use 'A' to move left");
        Debug.Log("Use 'S' to move backwards");
        Debug.Log("Use 'D' to move right");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        float xInput = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zInput = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xInput,0,zInput);
    }
}
