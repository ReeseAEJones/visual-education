using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {
    public Transform cubePrefab, cylinderPrefab, spherePrefab;
    private Transform current = null;
    public GUIPrinter printer;
    private List<string> linears;
    private List<string> areas;
    private List<string> volumes;
    private List<Transform> objects;
    private Vector3 objPos;
    private string mode;
    private int i;

	// Use this for initialization
	void Start () {
        this.printer = GetComponent<GUIPrinter>();
        this.mode = Settings.mode;
        this.i = 0;
        objects = new List<Transform>();
        linears = new List<string>();
        areas = new List<string>();
        volumes = new List<string>();
        objects.Add(cubePrefab);
        objects.Add(cylinderPrefab);
        objects.Add(spherePrefab);
        this.objPos.x = -8;
        this.objPos.y = 4;
        this.objPos.z = 2;
    }

    void createLinear(){
        this.linears = new List<string>();
        string cubeString = "Cube info:\nLength = " + 
            (current.GetChild(1).transform.localScale.x).ToString() + "\nWidth = " +
                                            (current.GetChild(1).transform.localScale.y).ToString() + "\nDepth = " +
                                            (current.GetChild(1).transform.localScale.z);
        string cylinderString = "Cylinder info:\nRadius = " +
            (current.GetChild(1).transform.localScale.x).ToString() + "\nHeight = " +
                                            (current.GetChild(1).transform.localScale.y);
        string sphereString = "Sphere info:\nRadius = " +
            (current.GetChild(1).transform.localScale.x).ToString();
        this.linears.Add(cubeString);
        this.linears.Add(cylinderString);
        this.linears.Add(sphereString);
    }
    void createArea()
    {
        this.areas = new List<string>();
        string cubeString = "Cube Area = " + 
            System.Math.Round(6 * current.GetChild(1).transform.localScale.x * current.GetChild(1).transform.localScale.y, 2).ToString() + "m^2";
        string cylinderString = "Cylinder Area = " +
            System.Math.Round(2 * ((Mathf.PI * current.GetChild(1).transform.localScale.x * current.GetChild(1).transform.localScale.x) + 
                                   (Mathf.PI * current.GetChild(1).transform.localScale.x * current.GetChild(1).transform.localScale.y)), 2).ToString() + "m^2";
        string sphereString = "Sphere Area = " +
             System.Math.Round(4 * Mathf.PI * current.GetChild(1).transform.localScale.x * current.GetChild(1).transform.localScale.x, 2).ToString() + "m^2";
        this.areas.Add(cubeString);
        this.areas.Add(cylinderString);
        this.areas.Add(sphereString);
    }

    void createVolume()
    {
        this.volumes = new List<string>();
        string cubeString = "Cube Volume = " +
            System.Math.Round(this.current.GetChild(1).transform.localScale.x * this.current.GetChild(1).transform.localScale.y *
                              this.current.GetChild(1).transform.localScale.z, 2).ToString() + "m^3";
        string cylinderString = "Cylinder Volume = " +
            System.Math.Round(Mathf.PI * this.current.GetChild(1).transform.localScale.x * this.current.GetChild(1).transform.localScale.x *
                              this.current.GetChild(1).transform.localScale.y, 2).ToString() + "m^3";
        string sphereString = "Sphere Volume = " +
            System.Math.Round(4 * Mathf.PI * this.current.GetChild(1).transform.localScale.x * this.current.GetChild(1).transform.localScale.x *
                              this.current.GetChild(1).transform.localScale.x / 3, 2).ToString() + "m^3";
        this.volumes.Add(cubeString);
        this.volumes.Add(cylinderString);
        this.volumes.Add(sphereString);
    }


    // Update is called once per frame
    void Update () {

        if (current != null)
        {
            createLinear();
            createArea();
            createVolume();
            if (Settings.mode.Equals(Settings.linearMode))
            {
                printer.Text = this.linears[(i - 1) % 3];
            }
            else if (Settings.mode.Equals(Settings.areaMode))
            {
                printer.Text = this.areas[(i - 1) % 3];
            }
            else if (Settings.mode.Equals(Settings.volumeMode))
            {
                printer.Text = this.volumes[(i - 1) % 3];
            }

        }
        if (Settings.mode.Equals(Settings.linearMode))
        {
            this.objPos = Settings.linearObjPos;
        }
        else if (Settings.mode.Equals(Settings.areaMode))
        {
            this.objPos = Settings.areaObjPos;
        }
        else if (Settings.mode.Equals(Settings.volumeMode))
        {
            this.objPos = Settings.volumeObjPos;
        }

    }

    private void OnMouseDown()
    {
        Debug.Log("HELLo");
        Vector4 location;
        location.x = 5;
        location.y = 5;
        location.z = 200;
        location.w = 100;
        printer.Location = location;
        if (current != null)
        {
            Destroy(current.gameObject);
        }
        if (!Settings.mode.Equals(Settings.noMode))
        {
            current = Instantiate(objects[i % 3], objPos, Quaternion.identity);
        }
        this.i++;
    }
}
