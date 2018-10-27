using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeAxis : MonoBehaviour {

    Vector3 size;
    // Use this for initialization
    void Start () {
        size = transform.localScale;
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetButton("ChangeX")){
            if (transform.localScale.x <= 0 && Input.GetAxis("ChangeX") < 0) { }
            else{
                if (Input.GetAxis("ChangeX") < 0)
                {
                    size.x--;
                }
                else{
                    size.x++;
                }
            }
        }
        if(Input.GetButton("ChangeY")){
            if(transform.localScale.y <= 0 && Input.GetAxis("ChangeY") < 0){}
            else
            {
                if (Input.GetAxis("ChangeY") < 0)
                {
                    size.y--;
                }
                else
                {
                    size.y++;
                }
            }
        }
        transform.localScale = size;
    }
}
