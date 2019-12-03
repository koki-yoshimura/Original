using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour {

    public static SaveManager Instance;
    public static int FirstTitle;
    public static int FirstShop;
    public static int FirstGasha;
    public static int FirstWepon;
    public static int FirstShooting;


    void Awake()
    {
        PlayerPrefs.DeleteKey("ReadTitle");
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
        GameDirector.savecoin = PlayerPrefs.GetInt("Coin");
        FirstTitle = PlayerPrefs.GetInt("ReadTitle");
        FirstShop = PlayerPrefs.GetInt("ReadShop");
        FirstGasha = PlayerPrefs.GetInt("ReadGasha");
        FirstWepon = PlayerPrefs.GetInt("ReadWepon");
        FirstShooting = PlayerPrefs.GetInt("ReadShooting");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Coin", GameDirector.savecoin);
        PlayerPrefs.SetInt("ReadTitle", FirstTitle);
        PlayerPrefs.SetInt("ReadShop", FirstShop);
        PlayerPrefs.SetInt("ReadGasha", FirstGasha);
        PlayerPrefs.SetInt("ReadWepon", FirstWepon);
        PlayerPrefs.SetInt("ReadShooting", FirstShooting);
        PlayerPrefs.Save();
    }
}