using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {

    public GameObject StartButton;
    public GameObject ShopButton;
    public GameObject GashaButton;
    public GameObject ShootingButton;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //スタートボタンを押すと非アクティブのボタンがアクティブとなる
    public void StartButtonDown()
    {
        StartButton.SetActive(false);
        ShopButton.SetActive(true);
        GashaButton.SetActive(true);
        ShootingButton.SetActive(true);

    }

    //soubiボタンを押してsoubiシーンに遷移する
    public void ShootingButtonDown()
    {
        SceneManager.LoadScene("soubi");
    }

    //shopボタンを押してshopシーンに遷移する
    public void ShopButtonDown()
    {
        SceneManager.LoadScene("shop");
    }

    //gashaボタンを押してgashaシーンに遷移する
    public void GashaButtonDown()
    {
        SceneManager.LoadScene("gasha");
    }
}
