using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour {

    GameObject shojicoin;

    int coin = 100;

    int itemkanri = 0;

    public GameObject Panel;
    public GameObject TextPanel;
    public GameObject BuyButton;
    public GameObject CancelButton;
    public GameObject tarinaiPanel;
    public GameObject tarinaiText;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject Button5;

    //装備画面に購入情報を伝える変数
    public static int shopbuy1 = 0;
    public static int shopbuy2 = 0;
    public static int shopbuy3 = 0;
    public static int shopbuy4 = 0;
    public static int shopbuy5 = 0;


    // Use this for initialization
    void Start () {
        this.shojicoin = GameObject.Find("ShojiCoin");

    }

    //GameDirector.savecoin
    void Update()
    {
        this.shojicoin.GetComponent<Text>().text = "所持コイン " + coin;

        if (shopbuy1 != 0)
           Button1.SetActive(false);

        if (shopbuy2 != 0)
            Button2.SetActive(false);

        if (shopbuy3 != 0)
            Button3.SetActive(false);

        if (shopbuy4 != 0)
            Button4.SetActive(false);

        if (shopbuy5 != 0)
            Button5.SetActive(false);

    }

    //1ボタンを押し続けた場合の処理
    public void GetMyOneButtonDown()
    {
        GetComponent<AudioSource>().Play();

        Panel.SetActive(true);
        TextPanel.SetActive(true);
        BuyButton.SetActive(true);
        CancelButton.SetActive(true);

        itemkanri = 1;
    }

    //2ボタンを押し続けた場合の処理
    public void GetMyTwoButtonDown()
    {
        GetComponent<AudioSource>().Play();

        Panel.SetActive(true);
        TextPanel.SetActive(true);
        BuyButton.SetActive(true);
        CancelButton.SetActive(true);

        itemkanri = 2;
    }

    //3ボタンを押し続けた場合の処理
    public void GetMyThreeButtonDown()
    {
        GetComponent<AudioSource>().Play();

        Panel.SetActive(true);
        TextPanel.SetActive(true);
        BuyButton.SetActive(true);
        CancelButton.SetActive(true);

        itemkanri = 3;
    }

    //4ボタンを押し続けた場合の処理
    public void GetMyFourButtonDown()
    {
        GetComponent<AudioSource>().Play();

        Panel.SetActive(true);
        TextPanel.SetActive(true);
        BuyButton.SetActive(true);
        CancelButton.SetActive(true);

        itemkanri = 4;
    }    
    
    //5ボタンを押し続けた場合の処理
    public void GetMyFiveButtonDown()
    {
        GetComponent<AudioSource>().Play();

        Panel.SetActive(true);
        TextPanel.SetActive(true);
        BuyButton.SetActive(true);
        CancelButton.SetActive(true);

        itemkanri = 5;
    }


    public void BuyButtonDown()
    {
        GetComponent<AudioSource>().Play();

        switch (itemkanri)
        {
            case 1:
                if (coin >= 10)
                {
                    shopbuy1 = 1;
                    coin -= 1;
                }
                else
                {
                    tarinaiPanel.SetActive(true);
                    tarinaiText.SetActive(true);
                }
                break;

            case 2:
                if (coin >= 10)
                {
                    shopbuy2 = 1;
                    coin -= 1;
                }
                else
                {
                    tarinaiPanel.SetActive(true);
                    tarinaiText.SetActive(true);
                }
                break;

            case 3:
                if (coin >= 10)
                {
                    shopbuy3 = 1;
                    coin -= 1;
                }
                else
                {
                    tarinaiPanel.SetActive(true);
                    tarinaiText.SetActive(true);
                }
                break;

            case 4:
                if (coin >= 10)
                {
                    shopbuy4 = 1;
                    coin -= 1;
                }
                else
                {
                    tarinaiPanel.SetActive(true);
                    tarinaiText.SetActive(true);
                }
                break;

            case 5:
                if (coin >= 10)
                {
                    shopbuy5 = 1;
                    coin -= 1;
                }
                else
                {
                    tarinaiPanel.SetActive(true);
                    tarinaiText.SetActive(true);
                }
                break;

        }


    }

    public void CancelButtonDown()
    {
        GetComponent<AudioSource>().Play();
        Panel.SetActive(false);
        TextPanel.SetActive(false);
        BuyButton.SetActive(false);
        CancelButton.SetActive(false);
        tarinaiPanel.SetActive(false);
        tarinaiText.SetActive(false);

    }

    //戻るボタンを押すとタイトルに遷移する
    public void ReturnButtonDown()
    {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("title");
    }
}
