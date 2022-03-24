using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xangle = 0;
    [SerializeField] float yangle = 0;
    [SerializeField] float zangle = 0;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xangle,yangle,zangle);
    }
}
