using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour {

    public static SaveManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        GameDirector.savecoin = PlayerPrefs.GetInt("coin");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("coin", GameDirector.savecoin);
        PlayerPrefs.Save();
    }
}