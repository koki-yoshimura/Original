using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

public class WeponManager : MonoBehaviour {

    public GameObject Panel;
    public GameObject TextPanel;
    public GameObject tutorialText;
    public GameObject XButton;

    public GameObject gasha1;
    public GameObject gasha2;
    public GameObject gasha3;

    public GameObject shop1;
    public GameObject shop2;
    public GameObject shop3;
    public GameObject shop4;
    public GameObject shop5;

    public ToggleGroup mToggleGroup;
    public ToggleGroup vToggleGroup;

    //playerに装備する装備
    public static int SoubiA = 0;
    public static int SoubiB = 0;
    public static int SoubiC = 0;
    public static int SoubiD = 0;

    //playerに装備する攻撃
    public static int SoubiE = 0;
    public static int SoubiF = 0;
    public static int SoubiG = 0;
    public static int SoubiH = 0;
    public static int SoubiI = 0;
    public static int SoubiJ = 0;

    // Use this for initialization
    void Start () {

        if (SaveManager.shokaiwepon == 0)
        {
            Panel.SetActive(true);
            TextPanel.SetActive(true);
            tutorialText.SetActive(true);
            XButton.SetActive(true);
        }



        //ガシャで手に入れたボタン、チェックボックスが装備画面に表示されるようにしている
        if (BoxGacha.Gasha1 == 1)
        {
            gasha1.SetActive(true);
        }

        if (BoxGacha.Gasha2 == 1)
        {
            gasha2.SetActive(true);
        }

        if (BoxGacha.Gasha3 == 1)
        {
            gasha3.SetActive(true);
        }



        //ショップで購入したボタン、チェックボックスが装備画面に表示されるようにしている
        if (ShopController.shopbuy1 == 1)
        {
            shop1.SetActive(true);
        }

        if (ShopController.shopbuy2 == 1)
        {
            shop2.SetActive(true);
        }

        if (ShopController.shopbuy3 == 1)
        {
            shop3.SetActive(true);
        }

        if (ShopController.shopbuy4 == 1)
        {
            shop4.SetActive(true);
        }

        if (ShopController.shopbuy5 == 1)
        {
            shop5.SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {



    }

    public void ReturnButtonDown()
    {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("title");
    }

    //スタートボタンを押すとシューティングゲームが始まる
    public void StartButtonDown()
    {
        GetComponent<AudioSource>().Play();

        Toggle tgl = mToggleGroup.ActiveToggles().FirstOrDefault();
        Toggle tgl2 = vToggleGroup.ActiveToggles().FirstOrDefault();

        switch (tgl.name)
        {
            case "Toggle":
                SoubiA = 1;
                SoubiB = 0;
                SoubiC = 0;
                SoubiD = 0;

                Debug.Log(SoubiA);


                break;

            case "Toggle (1)":
                SoubiB = 1;
                SoubiA = 0;
                SoubiC = 0;
                SoubiD = 0;

                Debug.Log(SoubiB);

                break;

            case "Toggle (2)":
                SoubiC = 1;
                SoubiA = 0;
                SoubiB = 0;
                SoubiD = 0;

                Debug.Log(SoubiC);

                break;

            case "Toggle (3)":
                SoubiD = 1;
                SoubiA = 0;
                SoubiB = 0;
                SoubiC = 0;

                Debug.Log(SoubiD);

                break;

        }

        switch (tgl2.name)
        {
            case "Toggle (3)":
                SoubiE = 1;
                SoubiF = 0;
                SoubiG = 0;
                SoubiH = 0;
                SoubiI = 0;
                SoubiJ = 0;

                Debug.Log(SoubiE);

                break;

            case "Toggle (4)":
                SoubiF = 1;
                SoubiE = 0;
                SoubiG = 0;
                SoubiH = 0;
                SoubiI = 0;
                SoubiJ = 0;

                Debug.Log(SoubiF);

                break;

            case "Toggle (5)":
                SoubiG = 1;
                SoubiE = 0;
                SoubiF = 0;
                SoubiH = 0;
                SoubiI = 0;
                SoubiJ = 0;

                Debug.Log(SoubiG);

                break;

            case "Toggle (6)":
                SoubiH = 1;
                SoubiE = 0;
                SoubiF = 0;
                SoubiG = 0;
                SoubiI = 0;
                SoubiJ = 0;

                Debug.Log(SoubiH);

                break;

            case "Toggle (7)":
                SoubiI = 1;
                SoubiE = 0;
                SoubiF = 0;
                SoubiG = 0;
                SoubiH = 0;
                SoubiJ = 0;

                Debug.Log(SoubiI);

                break;

            case "Toggle (8)":
                SoubiJ = 1;
                SoubiE = 0;
                SoubiF = 0;
                SoubiG = 0;
                SoubiH = 0;
                SoubiI = 0;

                Debug.Log(SoubiJ);

                break;
        }


        if (SaveManager.shokaishooting == 0)
        {
            Panel.SetActive(true);
            TextPanel.SetActive(true);
            tutorialText.SetActive(true);
            XButton.SetActive(true);

            SceneManager.LoadScene("shokaishooting");
        }
        else
        {
            SceneManager.LoadScene("shooting");
        }

    }

    public void XButtonDown()
    {
        GetComponent<AudioSource>().Play();
        Panel.SetActive(false);
        TextPanel.SetActive(false);
        tutorialText.SetActive(false);
        XButton.SetActive(false);

        SaveManager.shokaiwepon = 1;
    }
}
