using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	Material objMaterial;
    Color objColor;

    // Use this for initialization
    void Start()
    {
        this.objMaterial = GetComponent<Renderer>().material;
        this.objColor = objMaterial.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("NewColor"))
        {
            Color randomColor;
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
