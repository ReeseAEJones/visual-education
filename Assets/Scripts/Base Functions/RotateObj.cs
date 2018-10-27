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
        transform.rotation = Quaternion.Euler(rotation);
    }

    void rotateX(float x)
    {
        rotation.x += x;
    }

    void rotateY(float y)
    {
        rotation.y += y;
    }

    void rotateZ(float z)
    {
        rotation.z += z;
    }
    
}
