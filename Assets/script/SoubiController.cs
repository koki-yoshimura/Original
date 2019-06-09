using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoubiController : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnValueChanged(UnityEngine.UI.Toggle toggle)
    {
        if (toggle.isOn)
        {
            string message = "";
            message += toggle.group.name;
            message += " の ";
            message += toggle.name;
            message += " にチェックが入った";
            Debug.Log(message);
        }
    }
}
