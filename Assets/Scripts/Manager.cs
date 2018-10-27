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
            shapes.Add(Instantiate(cubePrefab, Vector3.zero, Quaternion.identity));
        }
        if (Input.GetButtonDown("SpawnSphere"))
        {
            shapes.Add(Instantiate(spherePrefab, Vector3.zero, Quaternion.identity));
        }
        if (Input.GetButtonDown("SpawnCylinder"))
        {
            shapes.Add(Instantiate(cylinderPrefab, Vector3.zero, Quaternion.identity));
        }
    }

    // Adds MoveObj, ResizeObj, and RotateObj script components to a specific object the user is focusing on.
    // Removes Same scripts from all other objects in scene.
    // Is called from an object being clicked on.
    public void UpdateFocus(GameObject clickedObj)
    {
        for (int i = 0; i < this.shapes.Count; i++)
        {
            shapes[i].gameObject.
        }
    }
}
