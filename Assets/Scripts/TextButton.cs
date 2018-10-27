using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.color = Color.black;
	}

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }

    void OnMouseUp()
    {
        Application.LoadLevel(1);
    }
}
