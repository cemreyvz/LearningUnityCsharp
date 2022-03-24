using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movea : MonoBehaviour
{ [SerializeField]  float moveSpeeds = 1.0f;
    

   [SerializeField] float yVall = 0;
    // Start is called before the first frame update
    void Start()
    {
        printIntructionss();
    }

    // Update is called once per framse
    void Update()
    {
        Moveplayers();
    }

    void printIntructionss()
    {
        Debug.Log("Cemre mükemmel bir insan");
    }

    void Moveplayers()
    {
float xVal = Input.GetAxis("Horizontal")*moveSpeeds*Time.deltaTime;
        float zVal = Input.GetAxis("Vertical")*moveSpeeds*Time.deltaTime;
        transform.Translate(xVal, yVall, zVal);
    }

}
