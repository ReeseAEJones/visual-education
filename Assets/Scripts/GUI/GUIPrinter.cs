using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIPrinter : MonoBehaviour {
    private string text;
    public string Text{ set { this.text = value; }}
    public Rect rect;
    public Rect position;
    // Use this for initialization
    void Start () {
        rect = new Rect(5, 5, 200, 100);
        position = new Rect(Screen.width / 2, Screen.height / 2, 5, 5);
	}
	
	// Update is called once per frame
	void Update () {
    }


    private void OnGUI()
    {
        GUI.Box(rect, text);
        GUI.Box(position, "");
        
    }
}

