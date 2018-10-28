using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButtonManager : MonoBehaviour {

    public ButtonManager buttonManager;
    public GUIPrinter printer;
    private List<string> prompts;
    private int i;
    // Use this for initialization
    void Start()
    {
        this.printer = GetComponent<GUIPrinter>();
        i = 0;
        prompts = new List<string>();
        prompts.Add("Welcome to Linear Properties!");
        prompts.Add("Welcome to Area Calculation!");
        prompts.Add("Welcome to Volume Calculation!");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Vector4 location;
        location.x = 5;
        location.y = Screen.height - 210;
        location.z = 200;
        location.w = 100;
        printer.Location = location;
        printer.Text = prompts[i % 3];
        if(i % 3 == 0){
            Settings.mode = Settings.linearMode;
        }
        else if(i % 3 == 1){
            Settings.mode = Settings.areaMode;
        }else{
            Settings.mode = Settings.volumeMode;
        }
        i++;
    }

}
