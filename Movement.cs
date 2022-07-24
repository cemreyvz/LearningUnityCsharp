using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] float mainthrust = 100 ;

    [SerializeField] float mainrotate= 100;

    private void Start()
    {
        

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Thrust();

        Rotation();

       

    }

    void Thrust()

    {
        if (Input.GetKey(KeyCode.B))

        {
            rb.AddRelativeForce(Vector3.up*mainthrust*Time.deltaTime);
        }
    }
    void Rotation()

    {
        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(mainrotate);

        }

        else if (Input.GetKey(KeyCode.D))

        {
            ApplyRotation(-mainrotate);

        }

        void ApplyRotation(float mainrotate)

        {
            rb.freezeRotation = true;
            transform.Rotate(Vector3.forward * mainrotate * Time.deltaTime);
            rb.freezeRotation = false; 
        }
    }

        }
    

   