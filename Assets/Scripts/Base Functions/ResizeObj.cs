using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeObj : MonoBehaviour {
    Vector3 size;
	// Use this for initialization
	void Start () {
        size = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale = size;
	}

    public void resizeX(float x)
    {
        size.x += x;
    }

    public void resizeY(float y)
    {
        size.y += y;
    }

    public void resizeZ(float z)
    {
        size.z += z;
    }

}
