using System.Collections;
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
