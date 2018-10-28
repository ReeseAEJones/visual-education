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
    public string Mode { set { this.mode = value; }}
    private int i;

	// Use this for initialization
	void Start () {
        this.printer = GetComponent<GUIPrinter>();
        this.mode = "Linear";
        i = 0;
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
        string cubeString = "Cube info:\nLength = " + 
            (current.gameObject.transform.localScale.x).ToString() + "\nWidth = " +
                                            (current.gameObject.transform.localScale.y).ToString() + "\nDepth = " +
                                            (current.gameObject.transform.localScale.z);
        string cylinderString = "Cylinder info:\nRadius = " +
            (current.gameObject.transform.localScale.x).ToString() + "\nHeight = " +
                                            (current.gameObject.transform.localScale.y);
        string sphereString = "Sphere info:\nRadius = " +
            (current.gameObject.transform.localScale.x).ToString();
        this.linears.Add(cubeString);
        this.linears.Add(cylinderString);
        this.linears.Add(sphereString);
    }
    void createArea()
    {
        string cubeString = "Cube Area = " + 
            System.Math.Round(6 * current.gameObject.transform.localScale.x * current.gameObject.transform.localScale.y, 2).ToString() + "m^2";
        string cylinderString = "Cylinder Area = " +
            System.Math.Round(2 * ((Mathf.PI * current.gameObject.transform.localScale.x * current.gameObject.transform.localScale.x) + 
                                   (Mathf.PI * current.gameObject.transform.localScale.x * current.gameObject.transform.localScale.y)), 2).ToString() + "m^2";
        string sphereString = "Sphere Area = " +
             System.Math.Round(4 * Mathf.PI * current.gameObject.transform.localScale.x * current.gameObject.transform.localScale.x, 2).ToString() + "m^2";
        this.areas.Add(cubeString);
        this.areas.Add(cylinderString);
        this.areas.Add(sphereString);
    }

    void createVolume()
    {
        string cubeString = "Cube Volume = " +
            System.Math.Round(current.gameObject.transform.localScale.x * current.gameObject.transform.localScale.y *
                              current.gameObject.transform.localScale.z, 2).ToString() + "m^3";
        string cylinderString = "Cylinder Volume = " +
            System.Math.Round(Mathf.PI * current.gameObject.transform.localScale.x * current.gameObject.transform.localScale.x *
                              current.gameObject.transform.localScale.y, 2).ToString() + "m^3";
        string sphereString = "Sphere Volume = " +
            System.Math.Round(4 * Mathf.PI * current.gameObject.transform.localScale.x * current.gameObject.transform.localScale.x *
                              current.gameObject.transform.localScale.x / 3, 2).ToString() + "m^3";
        this.volumes.Add(cubeString);
        this.volumes.Add(cylinderString);
        this.volumes.Add(sphereString);
    }


    // Update is called once per frame
    void Update () {

        if (mode.Equals("Linear"))
        {
            printer.Text = linears[i % 3];
        }
        else if (mode.Equals("Area"))
        {
            printer.Text = areas[i % 3];
        }
        else
        {
            printer.Text = volumes[i % 3];
        }
        createLinear();
        createArea();
        createVolume();
    }

    private void OnMouseDown()
    {
        Vector4 location;
        location.x = 5;
        location.y = 5;
        location.z = 200;
        location.w = 100;
        printer.Location = location;
        if(current != null){
            Destroy(current.gameObject);
        }
        current = Instantiate(objects[i % 3], objPos, Quaternion.identity);
        createLinear();
        createArea();
        createVolume();

        i++;

    }
}
