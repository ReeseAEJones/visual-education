using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIPrinter : MonoBehaviour {
    private string text;
    public string Text{ set { this.text = value; }}
	// Use this for initialization
	void Start () {
        this.text = "Initial";
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnGUI()
    {
        GUI.Box(new Rect(5, 5, 200, 100), text);
    }
}

