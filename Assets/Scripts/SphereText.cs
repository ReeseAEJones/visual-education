using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereText : MonoBehaviour {
    string text;
    Transform sphere;
    // Use this for initialization
    void Start()
    {
        this.sphere = this.gameObject.transform;
        this.text = sphere.GetChild(0).GetComponent<TextMesh>().text;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 size = sphere.GetChild(1).transform.localScale;
        text = "Sphere Description:";
        text += "\nArea: " + (4*Mathf.PI*size.x*size.x).ToString() + "m^2";
        text += "\nVolume : " + (4 * Mathf.PI * size.x * size.x * size.x / 3).ToString() + "m^3";
        sphere.GetChild(0).GetComponent<TextMesh>().text = text;
    }
}
