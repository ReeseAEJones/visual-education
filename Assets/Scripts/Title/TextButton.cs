using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.color = Color.white;
	}

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    void OnMouseUp()
    {
        SceneManager.LoadScene(1);
    }
}
