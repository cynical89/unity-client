using UnityEngine;
using System.Collections;
using System;

public class startArgs : MonoBehaviour
{
    private static string _gameId = string.Empty;
    private static string _arg = "--args-g";

	// Use this for initialization
	void Start ()
	{
	    string[] arguments = Environment.GetCommandLineArgs();

	    if (arguments.Length <= 1)
	    {
            Debug.Log("No modifiers supplied");
            Application.Quit();
        }
	    var cmdInfo = arguments[1];

	    if (cmdInfo.Contains(_arg) == false)
	    {
	        Debug.Log("Incorrect Modifier supplied");
	        Application.Quit();
	    }

	    if (cmdInfo.Length != 45)
	    {
	        Debug.Log("Incorrect argument supplied");
            Application.Quit();
	    }

	    _gameId = cmdInfo.Substring(_arg.Length + 1, 36);

	    if (_gameId.Length != 36)
	    {
	        Debug.Log("Incorrect ID supplied");
	        Application.Quit();
	    }
	}
	
	// Update is called once per frame
	void OnGUI () {
	    Rect r = new Rect(5, 5, 800, 500);
        GUI.Label(r, _gameId);
	}
}
