using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereChoice : MonoBehaviour
{

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
        SettingData.ObjNumber = 2;
        SceneManager.LoadScene(3);
    }
}
