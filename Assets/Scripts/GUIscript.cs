using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerSettings.GUItext = "Welcome to the VisEd shape game!";
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 170, 30), PlayerSettings.GUItext);
    }
}
