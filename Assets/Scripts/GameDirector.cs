using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

    public static bool IsClear;

    float remainingTime = 30.0f;

    GameObject coinText;

    GameObject HPText;

    int coin = 0;

    public static int savecoin = 0;

    int HP = 10;

    public void GetCoin()//PlayerがCoinを獲得した時に加算する
    {
        this.coin += 1;
        savecoin += 1;
    }

    public void Damage()//PlayerがEnemyに当たった時に減算する
    {
        this.HP -= 1;
    }

    // Use this for initialization
    void Start () {
        this.coinText = GameObject.Find("CoinText");
        this.HPText = GameObject.Find("HPText");
    }
	
	// Update is called once per frame
	void Update () {

        remainingTime -= Time.deltaTime;

        //クリア、ゲームオーバーの判定
        if (remainingTime <= 0)
        {
            IsClear = true;
            SceneManager.LoadScene("rizaruto");
        }
        else if(HP <= 0)
        {
            IsClear = false;
            SceneManager.LoadScene("rizaruto");
        }


        this.HPText.GetComponent<Text>().text = this.HP.ToString();//減算したHPを画面に表示する
        this.coinText.GetComponent<Text>().text = this.coin.ToString() + " コイン";//加算したCoinの数を画面に表示する
    }
}
