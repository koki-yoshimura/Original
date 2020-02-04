using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour {

    public static SaveManager Instance;
    public static int FirstTitle;
    public static int FirstShop;
    public static int FirstGasha;
    public static int FirstWeapon;
    public static int FirstShooting;


    void Awake()
    {
        if (Instance == null)//タイトルに来るたびに複数の同じゲームオブジェクトが存在することにならないようにinstanceの中身がないときだけ実施している
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);//シーンが切り替わっても削除しないようにしている
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        GameDirector.SaveCoin = PlayerPrefs.GetInt("Coin");
        FirstTitle = PlayerPrefs.GetInt("SecondTitle");
        FirstShop = PlayerPrefs.GetInt("SecondShop");
        FirstGasha = PlayerPrefs.GetInt("SecondGasha");
        FirstWeapon = PlayerPrefs.GetInt("SecondWeapon");
        FirstShooting = PlayerPrefs.GetInt("SecondShooting");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Coin", GameDirector.SaveCoin);
        PlayerPrefs.SetInt("SecondTitle", FirstTitle);
        PlayerPrefs.SetInt("SecondShop", FirstShop);
        PlayerPrefs.SetInt("SecondGasha", FirstGasha);
        PlayerPrefs.SetInt("SecondWeapon", FirstWeapon);
        PlayerPrefs.SetInt("SecondShooting", FirstShooting);
        PlayerPrefs.Save();
    }
}