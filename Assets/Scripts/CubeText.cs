using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeText : MonoBehaviour {
    string text;
    Vector3 size;
	// Use this for initialization
	void Start () {
        this.text = GetComponent<TextMesh>().text;
        this.size = transform.localScale;
    }
	
	// Update is called once per frame
	void Update () {
        text = "Volume : " + (size.x * size.y * size.z).ToString();
        GetComponent<TextMesh>().text = text;

    }
}
