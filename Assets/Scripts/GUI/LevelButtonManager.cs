using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButtonManager : MonoBehaviour {

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
        printer.Text = prompts[i % 3];
        i++;
    }
}
