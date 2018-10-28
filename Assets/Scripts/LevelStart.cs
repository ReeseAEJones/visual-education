using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStart : MonoBehaviour
{
    Transform Player;
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
        if (gameObject.name.Equals("LinearStart"))
        {
            Settings.mode = Settings.linearMode;
            Player.transform.position = Settings.linearPos;
        }
        else if (gameObject.name.Equals("AreaStart"))
        {
            Settings.mode = Settings.areaMode;
            Player.transform.position = Settings.areaPos;

        } else
        {
            Settings.mode = Settings.volumeMode;
            Player.transform.position = Settings.volumePos;

        }

    }
}
