using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Rotate object component
 * can be applied to any object
 * moves its x, y, and z coordinates based on 
 * defined horizontal and vertical buttons
 */ 


public class RotateObj : MonoBehaviour {
    Vector3 rotation;
	// Use this for initialization
	void Start () {
        rotation = transform.rotation.eulerAngles;

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButton("RotateHoriz")) 
            rotateX(Input.GetAxis("RotateHoriz"));
        

        if (Input.GetButton("RotateVert"))
            rotateY(Input.GetAxis("RotateVert"));

        transform.rotation = Quaternion.Euler(rotation);
    }

    // rotates on the x axis
    // rotates about the y axis
    void rotateX(float x)
    {
        rotation.y -= x;
    }

    // rotates on the y axis
    // rotates about the x axis
    void rotateY(float y)
    {
        rotation.x += y;
    }

    // rotates about the z axis
    void rotateZ(float z)
    {
        rotation.z += z;
    }
    
}
