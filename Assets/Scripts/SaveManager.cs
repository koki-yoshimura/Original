using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour {

    public static SaveManager Instance;
    public static int Shokaititle;
    public static int Shokaishop;
    public static int Shokaigasha;
    public static int Shokaiwepon;
    public static int Shokaishooting;


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
        GameDirector.savecoin = PlayerPrefs.GetInt("coin");
        Shokaititle = PlayerPrefs.GetInt("kidokutitle");
        Shokaishop = PlayerPrefs.GetInt("kidokushop");
        Shokaigasha = PlayerPrefs.GetInt("kidokugasha");
        Shokaiwepon = PlayerPrefs.GetInt("kidokuwepon");
        Shokaishooting = PlayerPrefs.GetInt("kidokushooting");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("coin", GameDirector.savecoin);
        PlayerPrefs.SetInt("kidokutitle", Shokaititle);
        PlayerPrefs.SetInt("kidokushop", Shokaishop);
        PlayerPrefs.SetInt("kidokugasha", Shokaigasha);
        PlayerPrefs.SetInt("kidokuwepon", Shokaiwepon);
        PlayerPrefs.SetInt("kidokushooting", Shokaishooting);
        PlayerPrefs.Save();
    }
}