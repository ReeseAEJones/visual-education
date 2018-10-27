using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxChoice : MonoBehaviour {

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    void OnMouseUp()
    {
        SettingData.ObjNumber = 0;
        SceneManager.LoadScene(2);
    }
}
