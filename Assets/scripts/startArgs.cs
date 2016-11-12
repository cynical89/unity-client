using UnityEngine;
using System.Collections;
using System;

public class startArgs : MonoBehaviour
{
    private static string _cmdInfo = string.Empty;

	// Use this for initialization
	void Start ()
	{
	    string[] arguments = Environment.GetCommandLineArgs();

	    foreach (string arg in arguments)
	    {
	        _cmdInfo += arg.ToString() + " : ";
	    }
	}
	
	// Update is called once per frame
	void OnGUI () {
	    Rect r = new Rect(5, 5, 800, 500);
        GUI.Label(r, _cmdInfo);
	}
}
