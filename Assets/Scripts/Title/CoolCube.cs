using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolCube : MonoBehaviour {

    Vector3 rot;

	// Use this for initialization
	void Start () {
        rot = transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
       
        rot.x += Random.Range(0f, 10f) * Time.deltaTime;
        rot.y += Random.Range(0f, 10f) * Time.deltaTime;
        rot.z += Random.Range(0f, 10f) * Time.deltaTime;

        transform.rotation = Quaternion.Euler(rot);
	}
}
