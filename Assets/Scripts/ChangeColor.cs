using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	MMaterial objMaterial;
    Color objColor;

    // Use this for initialization
    void Start()
    {
        this.objMaterial = GetComponent<Renderer>().material;
        this.objColor = objMaterial.color;
    }

    void ChangeColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
