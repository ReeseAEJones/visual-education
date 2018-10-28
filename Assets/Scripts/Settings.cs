using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Settings {
    public const string linearMode = "Linear";
    public const string areaMode = "Area";
    public const string volumeMode = "Linear";
    public const string noMode = "None";
    public static string mode = noMode;

    public static Vector3 linearPos = new Vector3(-89, 1,(float)125.5287);
    public static Vector3 areaPos = new Vector3(103.5547f, 4, -85.63604f);
    public static Vector3 volumePos = new Vector3(89.25908f, 4, -101.6221f);
    public static Vector3 hubPos = new Vector3(0, 4, 0);

    public static Vector3 linearObjPos = new Vector3((float)-118.06438, 4, (float)135.5287);
    public static Vector3 areaObjPos = new Vector3(140.5547f, 4, -80.63604f);
    public static Vector3 volumeObjPos = new Vector3(99.25908f, 4, -101.6221f);

    
}
