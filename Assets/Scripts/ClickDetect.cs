using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetect : MonoBehaviour {

    //Reference to Manager script for calling function in OnClick()
    private Manager managerScript;
    public Manager ManagerScript
    {
        set { this.managerScript = value; }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        managerScript.UpdateFocus(transform.parent);
    }
}
