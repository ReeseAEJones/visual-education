using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIPrinter : MonoBehaviour {
    private string text;
    public string Text{ set { this.text = value; }}
    private Vector4 location;
    public Vector4 Location{ set { this.location = value; }}
    public Rect rect;
    public Rect position;
    // Use this for initialization
    void Start () {

        position = new Rect(Screen.width / 2, Screen.height / 2, 5, 5);
	}
	
	// Update is called once per frame
	void Update () {
    }


    private void OnGUI()
    {
        rect = new Rect(location.x, location.y, location.z, location.w);
        GUI.Box(rect, text);
        GUI.Box(position, "");
        
    }
}

