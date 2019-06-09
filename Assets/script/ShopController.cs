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
    public static int shopbuyE = 0;
    public static int shopbuyF = 0;


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
            shopbuyB += 1;
            GameDirector.savecoin -= 1;
        }

    }

    //2ボタンを押し続けた場合の処理
    public void GetMyTwoButtonDown()
    {
        if (GameDirector.savecoin >= 2)
        {
            shopbuyC += 1;
            GameDirector.savecoin -= 2;
        }
    }

    //3ボタンを押し続けた場合の処理
    public void GetMyThreeButtonDown()
    {
        if (GameDirector.savecoin >= 3)
        {
            shopbuyE += 1;
            GameDirector.savecoin -= 3;
        }
    }

    //4ボタンを押し続けた場合の処理
    public void GetMyFourButtonDown()
    {
        if (GameDirector.savecoin >= 4)
        {
            shopbuyF += 1;
            GameDirector.savecoin -= 4;
        }
    }

    //5ボタンを押し続けた場合の処理
    public void GetMyFiveButtonDown()
    {
        if (GameDirector.savecoin >= 5)
        {
            shopbuyE += 1;
            GameDirector.savecoin -= 5;
        }
    }

    public void ReturnButtonDown()
    {
        SceneManager.LoadScene("title");
    }
}
