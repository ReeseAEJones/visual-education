using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeText : MonoBehaviour {
    Transform cube;
    string text;
	// Use this for initialization
	void Start () {
        this.cube = this.gameObject.transform;
        this.text = cube.GetChild(0).GetComponent<TextMesh>().text;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 size = cube.GetChild(1).transform.localScale;
        text = "Cube Description:";
        text += "\nArea: " + (6 * size.x * size.y).ToString() + "m^2";
        text += "\nVolume : " + (size.x * size.y * size.z).ToString() + "m^3";
        cube.GetChild(0).GetComponent<TextMesh>().text = text;
    }
}
