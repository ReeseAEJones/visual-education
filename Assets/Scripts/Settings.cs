using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Settings {
    public static string mode;
    public const string linearMode = "Linear";
    public const string areaMode = "Area";
    public const string volumeMode = "Linear";
    public const string noMode = "None";

    public static Vector3 linearPos = new Vector3(1, 1, 1);
    public static Vector3 areaPos = new Vector3(1, 1, 1);
    public static Vector3 volumePos = new Vector3(1, 1, 1);
    public static Vector3 hubPos = new Vector3(0, 4, 0);

    public static Vector3 linearObjPos = new Vector3(4, 1, 1);
    public static Vector3 areaObjPos = new Vector3(4, 1, 1);
    public static Vector3 volumeObjPos = new Vector3(4, 1, 1);
}
