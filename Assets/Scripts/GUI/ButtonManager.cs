using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {
    public Transform cubePrefab, cylinderPrefab, spherePrefab;
    private Transform current = null;
    public GUIPrinter printer;
    private List<string> prompts;
    private List<Transform> objects;
    private Vector3 objPos;
    private int i;
	// Use this for initialization
	void Start () {
        this.printer = GetComponent<GUIPrinter>();
        i = 0;
        objects = new List<Transform>();
        prompts = new List<string>();
        prompts.Add("Cube");
        prompts.Add("Cylinder");
        prompts.Add("Sphere");
        objects.Add(cubePrefab);
        objects.Add(cylinderPrefab);
        objects.Add(spherePrefab);
        this.objPos.x = -8;
        this.objPos.y = 4;
        this.objPos.z = 2;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if(current != null){
            Destroy(current.gameObject);
        }
        current = Instantiate(objects[i % 3], objPos, Quaternion.identity);
       
        printer.Text = prompts[i % 3];
        i++;
    }
}
