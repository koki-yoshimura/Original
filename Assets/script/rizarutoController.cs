using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rizarutoController : MonoBehaviour {

    GameObject rizaruto;

	// Use this for initialization
	void Start () {

        this.rizaruto = GameObject.Find("Text");
		
	}
	
	// Update is called once per frame
	void Update () {

        if (GameDirector.IsClear == true)
        {
            // クリアしたときの処理
        }
        else
        {
            // ゲームオーバーの時の処理
            this.rizaruto.GetComponent<Text>().text = "Game Over";
        }

    }
}
