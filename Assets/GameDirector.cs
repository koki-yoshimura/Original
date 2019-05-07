﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject coinText;

    int coin = 0;

    public void GetCoin()
    {
        this.coin += 1;
    }

	// Use this for initialization
	void Start () {
        this.coinText = GameObject.Find("CoinText");
	}
	
	// Update is called once per frame
	void Update () {
        this.coinText.GetComponent<Text>().text = this.coin.ToString() + " コイン";
	}
}
