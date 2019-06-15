using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour {

    GameObject shojicoin;
    GameObject panel;

    public static int shopbuyB = 0;
    public static int shopbuyC = 0;


    // Use this for initialization
    void Start () {
        this.shojicoin = GameObject.Find("ShojiCoin");
		this.panel = GameObject.Find("Panel");
        panel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        this.shojicoin.GetComponent<Text>().text = "所持コイン " + GameDirector.savecoin;
	}

    //1ボタンを押し続けた場合の処理
    public void GetMyOneButtonDown()
    {
        if(GameDirector.savecoin >= 1)
        {
            //装備画面にボタン表示
            shopbuyB += 1;
            GameDirector.savecoin -= 1;
            Debug.Log("B購入");
        }

    }

    //2ボタンを押し続けた場合の処理
    public void GetMyTwoButtonDown()
    {
        if (GameDirector.savecoin >= 2)
        {
            //装備画面にボタン表示
            shopbuyC += 1;
            GameDirector.savecoin -= 2;
            Debug.Log("C購入");
        }
    }


    //戻るボタンを押すとタイトルに遷移する
    public void ReturnButtonDown()
    {
        SceneManager.LoadScene("title");
    }
}
