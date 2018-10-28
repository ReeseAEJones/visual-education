using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIPrinter : MonoBehaviour {
    private string text;
    public string Text{ set { this.text = value; }}
    private Rect rect;
    public Texture2D crosshair;
    public Rect position;
    // Use this for initialization
    void Start () {
        rect = new Rect(5, 5, 200, 100);
        this.text = "Initial";
        position = new Rect(Screen.width / 2, Screen.height / 2, 5, 5);
	}
	
	// Update is called once per frame
	void Update () {
        // position = new Rect((Screen.width - crosshair.width) / 2, (Screen.height - crosshair.height) / 2, crosshair.width, crosshair.height);
    }


    private void OnGUI()
    {
        GUI.Box(rect, text);
        GUI.Box(position, "");
        // GUI.DrawTexture(position, crosshair);
        /*
        float xMin = (Screen.width / 2) - (crosshairImage.width / 2);
        float yMin = (Screen.height / 2) - (crosshairImage.height / 2);
        GUI.DrawTexture(new Rect(xMin, yMin, crosshairImage.width, crosshairImage.height), crosshairImage);
        */
    }
}

