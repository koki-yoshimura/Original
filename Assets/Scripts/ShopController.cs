using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour {

    GameObject possessionCoin;

    int itemkanri = 0;

    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject textPanel;
    [SerializeField] private GameObject buyButton;
    [SerializeField] private GameObject cancelButton;
    [SerializeField] private GameObject shortagePanel;
    [SerializeField] private GameObject shortageText;
    [SerializeField] private GameObject moveButton;
    [SerializeField] private GameObject buyText;
    [SerializeField] private GameObject tutorialText;
    [SerializeField] private GameObject xButton;
    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject button2;
    [SerializeField] private GameObject button3;
    [SerializeField] private GameObject button4;
    [SerializeField] private GameObject button5;
    [SerializeField] private GameObject questionText;
    [SerializeField] private AudioSource audioSource;



    //装備画面に購入情報を伝える変数
    public static int Shopbuy1 = 0;
    public static int Shopbuy2 = 0;
    public static int Shopbuy3 = 0;
    public static int Shopbuy4 = 0;
    public static int Shopbuy5 = 0;


    // Use this for initialization
    void Start () {
        this.possessionCoin = GameObject.Find("PossessionCoin");

        if (SaveManager.FirstShop == 0)
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
        this.possessionCoin.GetComponent<Text>().text = "所持コイン " + GameDirector.SaveCoin;

        if (Shopbuy1 != 0)
           button1.SetActive(false);

        if (Shopbuy2 != 0)
            button2.SetActive(false);

        if (Shopbuy3 != 0)
            button3.SetActive(false);

        if (Shopbuy4 != 0)
            button4.SetActive(false);

        if (Shopbuy5 != 0)
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
        questionText.SetActive(true);

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
        questionText.SetActive(true);

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
        questionText.SetActive(true);

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
        questionText.SetActive(true);

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
        questionText.SetActive(true);

        itemkanri = 5;
    }


    public void BuyButtonDown()
    {
        audioSource.Play();

        switch (itemkanri)
        {
            case 1:
                if (GameDirector.SaveCoin >= 10)
                {
                    Shopbuy1 = 1;
                    GameDirector.SaveCoin -= 10;

                    shortagePanel.SetActive(true);
                    buyText.SetActive(true);
                    moveButton.SetActive(true);
                    buyButton.SetActive(false);
                    cancelButton.SetActive(false);
                    questionText.SetActive(false);

                }
                else
                {
                    shortagePanel.SetActive(true);
                    shortageText.SetActive(true);
                }
                break;

            case 2:
                if (GameDirector.SaveCoin >= 10)
                {
                    Shopbuy2 = 1;
                    GameDirector.SaveCoin -= 10;

                    shortagePanel.SetActive(true);
                    buyText.SetActive(true);
                    moveButton.SetActive(true);
                    buyButton.SetActive(false);
                    cancelButton.SetActive(false);
                    questionText.SetActive(false);
                }
                else
                {
                    shortagePanel.SetActive(true);
                    shortageText.SetActive(true);
                }
                break;

            case 3:
                if (GameDirector.SaveCoin >= 10)
                {
                    Shopbuy3 = 1;
                    GameDirector.SaveCoin -= 10;

                    shortagePanel.SetActive(true);
                    buyText.SetActive(true);
                    moveButton.SetActive(true);
                    buyButton.SetActive(false);
                    cancelButton.SetActive(false);
                    questionText.SetActive(false);
                }
                else
                {
                    shortagePanel.SetActive(true);
                    shortageText.SetActive(true);
                }
                break;

            case 4:
                if (GameDirector.SaveCoin >= 10)
                {
                    Shopbuy4 = 1;
                    GameDirector.SaveCoin -= 10;

                    shortagePanel.SetActive(true);
                    buyText.SetActive(true);
                    moveButton.SetActive(true);
                    buyButton.SetActive(false);
                    cancelButton.SetActive(false);
                    questionText.SetActive(false);
                }
                else
                {
                    shortagePanel.SetActive(true);
                    shortageText.SetActive(true);
                }
                break;

            case 5:
                if (GameDirector.SaveCoin >= 10)
                {
                    Shopbuy5 = 1;
                    GameDirector.SaveCoin -= 10;

                    shortagePanel.SetActive(true);
                    buyText.SetActive(true);
                    moveButton.SetActive(true);
                    buyButton.SetActive(false);
                    cancelButton.SetActive(false);
                    questionText.SetActive(false);
                }
                else
                {
                    shortagePanel.SetActive(true);
                    shortageText.SetActive(true);
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
        shortagePanel.SetActive(false);
        shortageText.SetActive(false);
        questionText.SetActive(false);



    }

    public void susumuButtonDown()
    {
        audioSource.Play();
        panel.SetActive(false);
        textPanel.SetActive(false);
        moveButton.SetActive(false);
        shortagePanel.SetActive(false);
        buyText.SetActive(false);
        questionText.SetActive(false);

    }

    public void XButtonDown()
    {
        audioSource.Play();
        panel.SetActive(false);
        textPanel.SetActive(false);
        tutorialText.SetActive(false);
        xButton.SetActive(false);

        SaveManager.FirstShop = 1;
    }

    //戻るボタンを押すとタイトルに遷移する
    public void ReturnButtonDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("Title");
    }
}
