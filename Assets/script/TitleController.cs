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

    //1ボタンを押し続けた場合の処理
    public void StartButtonDown()
    {
        StartButton.SetActive(false);
        ShopButton.SetActive(true);
        GashaButton.SetActive(true);
        ShootingButton.SetActive(true);

    }

    //2ボタンを押し続けた場合の処理
    public void ShootingButtonDown()
    {
        SceneManager.LoadScene("soubi");
    }

    //3ボタンを押し続けた場合の処理
    public void ShopButtonDown()
    {
        SceneManager.LoadScene("shop");
    }

    //4ボタンを押し続けた場合の処理
    public void GashaButtonDown()
    {
        SceneManager.LoadScene("gasha");
    }
}
