using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeponManager : MonoBehaviour {

    public GameObject SoubiB;
    public GameObject SoubiBButton;
    public GameObject SoubiC;
    public GameObject SoubiCButton;
    public GameObject SoubiE;
    public GameObject SoubiEButton;
    public GameObject SoubiF;
    public GameObject SoubiFButton;

    // Use this for initialization
    void Start () {

        //ショップで購入したボタン、チェックボックスが装備画面に表示されるようにしている
        if (ShopController.shopbuyB == 1)
        {
            SoubiB.SetActive(true);
            SoubiBButton.SetActive(true);
        }

        if (ShopController.shopbuyC == 1)
        {
            SoubiC.SetActive(true);
            SoubiCButton.SetActive(true);
        }

        //ガシャで手に入れたボタン、チェックボックスが装備画面に表示されるようにしている
        if (BoxGacha.GashaE == 1)
        {
            SoubiE.SetActive(true);
            SoubiEButton.SetActive(true);
        }

        if (BoxGacha.GashaF == 1)
        {
            SoubiF.SetActive(true);
            SoubiFButton.SetActive(true);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //スタートボタンを押すとシューティングゲームが始まる
    public void StartButtonDown()
    {
        SceneManager.LoadScene("shooting");
    }
}
