/*
* file MoveObj.cs
* @author Giovana Puccini
* @email gxp6079@rit.edu
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Method implementation for moving the object in the x, y and z dirrection by
// a given amount
public class MoveObj : MonoBehaviour {

	private Vector3 objLocation;

	// Use this for initialization
	void Start () {
			this.objLocation = transform.position;
	}

	public void moveX(float amount){
		 objLocation.x += amount;
	}

	public void moveY(float amount){
		objLocation.y += amount;
	}

	public void moveZ(float amount){
			objLocation.z += amount;
	}

	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Horizontal"))
            moveX(Input.GetAxis("Horizontal"));

        if (Input.GetButton("Vertical"))
            moveY(Input.GetAxis("Vertical"));

        transform.position = objLocation;
	}
}
