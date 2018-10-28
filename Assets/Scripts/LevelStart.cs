using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStart : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (gameObject.name.Equals("linearModeButton"))
        {
            Settings.mode = Settings.linearMode;
        }
        if (gameObject.name.Equals("areaModeButton"))
        {
            Settings.mode = Settings.areaMode;

        } else
        {
            Settings.mode = Settings.volumeMode;

        }

    }
}
