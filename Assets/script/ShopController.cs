using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour {

    GameObject shojicoin;

    int itemkanri = 0;

    [SerializeField] private AudioSource audioSource;

    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject textPanel;
    [SerializeField] private GameObject buyButton;
    [SerializeField] private GameObject cancelButton;
    [SerializeField] private GameObject tarinaiPanel;
    [SerializeField] private GameObject tarinaiText;
    [SerializeField] private GameObject susumuButton;
    [SerializeField] private GameObject buyText;
    [SerializeField] private GameObject tutorialText;
    [SerializeField] private GameObject xButton;
    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject button2;
    [SerializeField] private GameObject button3;
    [SerializeField] private GameObject button4;
    [SerializeField] private GameObject button5;
    [SerializeField] private GameObject questiontext;



    //装備画面に購入情報を伝える変数
    public static int shopbuy1 = 0;
    public static int shopbuy2 = 0;
    public static int shopbuy3 = 0;
    public static int shopbuy4 = 0;
    public static int shopbuy5 = 0;


    // Use this for initialization
    void Start () {
        this.shojicoin = GameObject.Find("ShojiCoin");

        if (SaveManager.shokaishop == 0)
        {
            panel.SetActive(true);
            textPanel.SetActive(true);
            tutorialText.SetActive(true);
            xButton.SetActive(true);
        }

    }

    //GameDirector.savecoin
    void Update()
    {
        this.shojicoin.GetComponent<Text>().text = "所持コイン " + GameDirector.savecoin;

        if (shopbuy1 != 0)
           button1.SetActive(false);

        if (shopbuy2 != 0)
            button2.SetActive(false);

        if (shopbuy3 != 0)
            button3.SetActive(false);

        if (shopbuy4 != 0)
            button4.SetActive(false);

        if (shopbuy5 != 0)
            button5.SetActive(false);

    }

    //1ボタンを押し続けた場合の処理
    public void GetMyOneButtonDown()
    {
        audioSource.Play();

        panel.SetActive(true);
        textPanel.SetActive(true);
        buyButton.SetActive(true);
        cancelButton.SetActive(true);
        questiontext.SetActive(true);

        itemkanri = 1;
    }

    //2ボタンを押し続けた場合の処理
    public void GetMyTwoButtonDown()
    {
        audioSource.Play();

        panel.SetActive(true);
        textPanel.SetActive(true);
        buyButton.SetActive(true);
        cancelButton.SetActive(true);
        questiontext.SetActive(true);

        itemkanri = 2;
    }

    //3ボタンを押し続けた場合の処理
    public void GetMyThreeButtonDown()
    {
        audioSource.Play();

        panel.SetActive(true);
        textPanel.SetActive(true);
        buyButton.SetActive(true);
        cancelButton.SetActive(true);
        questiontext.SetActive(true);

        itemkanri = 3;
    }

    //4ボタンを押し続けた場合の処理
    public void GetMyFourButtonDown()
    {
        audioSource.Play();

        panel.SetActive(true);
        textPanel.SetActive(true);
        buyButton.SetActive(true);
        cancelButton.SetActive(true);
        questiontext.SetActive(true);

        itemkanri = 4;
    }    
    
    //5ボタンを押し続けた場合の処理
    public void GetMyFiveButtonDown()
    {
        audioSource.Play();

        panel.SetActive(true);
        textPanel.SetActive(true);
        buyButton.SetActive(true);
        cancelButton.SetActive(true);
        questiontext.SetActive(true);

        itemkanri = 5;
    }


    public void BuyButtonDown()
    {
        audioSource.Play();

        switch (itemkanri)
        {
            case 1:
                if (GameDirector.savecoin >= 10)
                {
                    shopbuy1 = 1;
                    GameDirector.savecoin -= 10;

                    tarinaiPanel.SetActive(true);
                    buyText.SetActive(true);
                    susumuButton.SetActive(true);
                    buyButton.SetActive(false);
                    cancelButton.SetActive(false);
                    questiontext.SetActive(false);

                }
                else
                {
                    tarinaiPanel.SetActive(true);
                    tarinaiText.SetActive(true);
                }
                break;

            case 2:
                if (GameDirector.savecoin >= 10)
                {
                    shopbuy2 = 1;
                    GameDirector.savecoin -= 10;

                    tarinaiPanel.SetActive(true);
                    buyText.SetActive(true);
                    susumuButton.SetActive(true);
                    buyButton.SetActive(false);
                    cancelButton.SetActive(false);
                    questiontext.SetActive(false);
                }
                else
                {
                    tarinaiPanel.SetActive(true);
                    tarinaiText.SetActive(true);
                }
                break;

            case 3:
                if (GameDirector.savecoin >= 10)
                {
                    shopbuy3 = 1;
                    GameDirector.savecoin -= 10;

                    tarinaiPanel.SetActive(true);
                    buyText.SetActive(true);
                    susumuButton.SetActive(true);
                    buyButton.SetActive(false);
                    cancelButton.SetActive(false);
                    questiontext.SetActive(false);
                }
                else
                {
                    tarinaiPanel.SetActive(true);
                    tarinaiText.SetActive(true);
                }
                break;

            case 4:
                if (GameDirector.savecoin >= 10)
                {
                    shopbuy4 = 1;
                    GameDirector.savecoin -= 10;

                    tarinaiPanel.SetActive(true);
                    buyText.SetActive(true);
                    susumuButton.SetActive(true);
                    buyButton.SetActive(false);
                    cancelButton.SetActive(false);
                    questiontext.SetActive(false);
                }
                else
                {
                    tarinaiPanel.SetActive(true);
                    tarinaiText.SetActive(true);
                }
                break;

            case 5:
                if (GameDirector.savecoin >= 10)
                {
                    shopbuy5 = 1;
                    GameDirector.savecoin -= 10;

                    tarinaiPanel.SetActive(true);
                    buyText.SetActive(true);
                    susumuButton.SetActive(true);
                    buyButton.SetActive(false);
                    cancelButton.SetActive(false);
                    questiontext.SetActive(false);
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
        audioSource.Play();
        panel.SetActive(false);
        textPanel.SetActive(false);
        buyButton.SetActive(false);
        cancelButton.SetActive(false);
        tarinaiPanel.SetActive(false);
        tarinaiText.SetActive(false);
        questiontext.SetActive(false);



    }

    public void susumuButtonDown()
    {
        audioSource.Play();
        panel.SetActive(false);
        textPanel.SetActive(false);
        susumuButton.SetActive(false);
        tarinaiPanel.SetActive(false);
        buyText.SetActive(false);
        questiontext.SetActive(false);

    }

    public void XButtonDown()
    {
        audioSource.Play();
        panel.SetActive(false);
        textPanel.SetActive(false);
        tutorialText.SetActive(false);
        xButton.SetActive(false);

        SaveManager.shokaishop = 1;
    }

    //戻るボタンを押すとタイトルに遷移する
    public void ReturnButtonDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("title");
    }
}
