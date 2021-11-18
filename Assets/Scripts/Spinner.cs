using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotateSpeed = 0f;
    [SerializeField] float yRotateSpeed = 1f;
    [SerializeField] float zRotateSpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotateSpeed, yRotateSpeed, zRotateSpeed);
        
    }
}
