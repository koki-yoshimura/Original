﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoubiController : MonoBehaviour {

    //playerに装備する装備
    public static int SoubiA = 0;
    public static int SoubiB = 0;
    public static int SoubiC = 0;

    //playerに装備する攻撃
    public static int SoubiD = 0;
    public static int SoubiE = 0;
    public static int SoubiF = 0;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (toggle.isOn)
        {
            if (toggle.gameObject.tag == "toggleA")
            {
                SoubiA += 1;
                SoubiB = 0;
            }
            else if (toggle.gameObject.tag == "toggleB")
            {
                SoubiB += 1;
                SoubiA = 0;
            }
            else if (toggle.gameObject.tag == "toggleD")
            {
                SoubiC += 1;
                SoubiD = 0;
            }
            else if (toggle.gameObject.tag == "toggleE")
            {
                SoubiD += 1;
                SoubiC = 0;
            }

        }

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

    public void SoubiAbuttondown(UnityEngine.UI.Toggle toggle)
    {

    }

    public void SoubiBbuttondown(UnityEngine.UI.Toggle toggle)
    {

    }

    public void SoubiDbuttondown(UnityEngine.UI.Toggle toggle)
    {

    }

    public void SoubiEbuttondown(UnityEngine.UI.Toggle toggle)
    {

    }
}
