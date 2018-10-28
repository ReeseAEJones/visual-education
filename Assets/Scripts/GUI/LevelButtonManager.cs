using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButtonManager : MonoBehaviour {

    public GUIPrinter printer;
    private List<string> prompts;
    private int i;
    public Transform Player;
    // Use this for initialization
    void Start()
    {
        this.printer = GetComponent<GUIPrinter>();
        i = 0;
        prompts = new List<string>();
        prompts.Add("Welcome to Linear Properties!");
        prompts.Add("Welcome to Area Calculation!");
        prompts.Add("Welcome to Volume Calculation!");
        printer.Text = prompts[i % 3];
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        i++;
        Vector4 location;
        location.x = 5;
        location.y = Screen.height - 210;
        location.z = 200;
        location.w = 100;
        printer.Location = location;
        printer.Text = prompts[(i) % 3];
        if(gameObject.name.Equals("LinearNext"))
        {
            Settings.mode = Settings.areaMode;
            Player.transform.position = Settings.areaPos;
        }
        else if(gameObject.name.Equals("AreaNext"))
        {
            Settings.mode = Settings.volumeMode;
            Player.transform.position = Settings.volumePos;
        }
    }

}
