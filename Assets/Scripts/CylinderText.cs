using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderText : MonoBehaviour {

    string text;
    Transform cylinder;
    // Use this for initialization
    void Start()
    {
        this.cylinder = this.gameObject.transform;
        this.text = cylinder.GetChild(0).GetComponent<TextMesh>().text;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 size = cylinder.GetChild(1).transform.localScale;
        // random
        text = "Cylinder Description:";
        text += "\nArea: " + (2 * ((Mathf.PI * size.x * size.x) + (Mathf.PI * size.x *size.y))).ToString() + "m^2";
        text += "\nVolume : " + (Mathf.PI * size.x * size.x * size.y).ToString() + "m^3";
        cylinder.GetChild(0).GetComponent<TextMesh>().text = text;
    }
}
