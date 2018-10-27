using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    // Prefabs to copy from when instantiating
    public Transform cubePrefab;
    public Transform spherePrefab;
    public Transform cylinderPrefab;

    // List to store all current objects in world
    List<Transform> shapes;

	// Use this for initialization
	void Start () {
        shapes = new List<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        CheckSpawn();
	}

    // User spawns objects from here
    private void CheckSpawn()
    {
        if (Input.GetButtonDown("SpawnCube"))
        {
            Transform tempCube = Instantiate(cubePrefab, Vector3.zero, Quaternion.identity);
            tempCube.GetChild(1).GetComponent<ClickDetect>().ManagerScript = this;
            shapes.Add(tempCube);
        }
        if (Input.GetButtonDown("SpawnSphere"))
        {
            Transform tempSphere = Instantiate(spherePrefab, Vector3.zero, Quaternion.identity);
            tempSphere.GetChild(1).GetComponent<ClickDetect>().ManagerScript = this;
            shapes.Add(tempSphere);
        }
        if (Input.GetButtonDown("SpawnCylinder"))
        {
            Transform tempCyl = Instantiate(cylinderPrefab, Vector3.zero, Quaternion.identity);
            tempCyl.GetChild(1).GetComponent<ClickDetect>().ManagerScript = this;
            shapes.Add(tempCyl);
        }
    }

    // Adds MoveObj, ResizeObj, and RotateObj script components to a specific object the user is focusing on.
    // Removes Same scripts from all other objects in scene.
    // Is called from an object being clicked on.
    public void UpdateFocus(Transform clickedObj)
    {
        for (int i = 0; i < this.shapes.Count; i++)
        {
            Debug.Log("GOING IN SHAPES");
            Destroy(shapes[i].gameObject.GetComponent<MoveObj>());
            Destroy(shapes[i].gameObject.GetComponentInChildren<RotateObj>());
            Destroy(shapes[i].gameObject.GetComponentInChildren<ResizeObj>());
        }

        clickedObj.gameObject.AddComponent<MoveObj>();
        clickedObj.GetChild(1).gameObject.AddComponent<RotateObj>();
        clickedObj.GetChild(1).gameObject.AddComponent<ResizeObj>();
    }
}
