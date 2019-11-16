using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour {

    public static SaveManager instance;
    public static int shokaititle;
    public static int shokaishop;
    public static int shokaigasha;
    public static int shokaiwepon;
    public static int shokaishooting;


    void Awake()
    {
        PlayerPrefs.DeleteKey("kidokutitle");
        if (instance == null)//タイトルに来るたびに複数の同じゲームオブジェクトが存在することにならないようにinstanceの中身がないときだけ実施している
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);//シーンが切り替わっても削除しないようにしている
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        GameDirector.savecoin = PlayerPrefs.GetInt("coin");
        shokaititle = PlayerPrefs.GetInt("kidokutitle");
        shokaishop = PlayerPrefs.GetInt("kidokushop");
        shokaigasha = PlayerPrefs.GetInt("kidokugasha");
        shokaiwepon = PlayerPrefs.GetInt("kidokuwepon");
        shokaishooting = PlayerPrefs.GetInt("kidokushooting");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("coin", GameDirector.savecoin);
        PlayerPrefs.SetInt("kidokutitle", shokaititle);
        PlayerPrefs.SetInt("kidokushop", shokaishop);
        PlayerPrefs.SetInt("kidokugasha", shokaigasha);
        PlayerPrefs.SetInt("kidokuwepon", shokaiwepon);
        PlayerPrefs.SetInt("kidokushooting", shokaishooting);
        PlayerPrefs.Save();
    }
}