using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Resize component, can be applied to any object since
 * all objects have x,y,and z sizes
 */ 

public class ResizeObj : MonoBehaviour {
    Vector3 size;
	// Use this for initialization
	void Start () {
        size = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Resize"))
        {
            resizeX(Input.GetAxis("Resize") * 0.1f);
            resizeY(Input.GetAxis("Resize") * 0.1f);
            resizeZ(Input.GetAxis("Resize") * 0.1f);
        }

        transform.localScale = size;
	}

    /* 
     *changes x dimension of prism
     */
    public void resizeX(float x)
    {
        size.x += x;
    }

    /* 
     *changes y dimension of prism
     */
    public void resizeY(float y)
    {
        size.y += y;
    }

    /* 
     *changes z dimension of prism
     */
    public void resizeZ(float z)
    {
        size.z += z;
    }

}
