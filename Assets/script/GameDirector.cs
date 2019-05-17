using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

    public static bool IsClear;

    float remainingTime = 60.0f;

    GameObject coinText;

    int coin = 0;

    public void GetCoin()//PlayerがCoinを獲得した時に加算する
    {
        this.coin += 1;
    }

	// Use this for initialization
	void Start () {
        this.coinText = GameObject.Find("CoinText");
	}
	
	// Update is called once per frame
	void Update () {

        remainingTime -= Time.deltaTime;

        if (remainingTime <= 0)
        {
            IsClear = false;
            SceneManager.LoadScene("rizaruto");
        }



            this.coinText.GetComponent<Text>().text = this.coin.ToString() + " コイン";//加算したCoinの数を画面に表示する
    }
}
