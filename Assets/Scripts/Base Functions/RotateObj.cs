using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour {
    Vector3 rotation;
	// Use this for initialization
	void Start () {
        rotation = transform.rotation.eulerAngles;

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButton("Horizontal")) 
            rotateX(Input.GetAxis("Horizontal"));
        

        if (Input.GetButton("Vertical"))
            rotateY(Input.GetAxis("Vertical"));

        transform.rotation = Quaternion.Euler(rotation);
    }

    void rotateX(float x)
    {
        rotation.y -= x;
    }

    void rotateY(float y)
    {
        rotation.x += y;
    }

    void rotateZ(float z)
    {
        rotation.z += z;
    }
    
}
