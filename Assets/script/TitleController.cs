using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {

    public GameObject StartButton;
    public GameObject ShopButton;
    public GameObject GashaButton;
    public GameObject ShootingButton;
    public GameObject Title;
    public GameObject Panel;
    public GameObject TextPanel;
    public GameObject tutorialText;
    public GameObject XButton;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //スタートボタンを押すと非アクティブのボタンがアクティブとなる
    public void StartButtonDown()
    {
        GetComponent<AudioSource>().Play();

        StartButton.SetActive(false);
        Title.SetActive(false);
        ShopButton.SetActive(true);
        GashaButton.SetActive(true);
        ShootingButton.SetActive(true);

        if (SaveManager.shokaititle == 0)
        {
            var dialog = (GameObject)Resources.Load("Prefabs/DialogPrefab");
            Instantiate(dialog, CommonDialog.transform, worldPositionStays: false);
        }
    }

    //soubiボタンを押してsoubiシーンに遷移する
    public void ShootingButtonDown()
    {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("soubi");
    }

    //shopボタンを押してshopシーンに遷移する
    public void ShopButtonDown()
    {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("shop");
    }

    //gashaボタンを押してgashaシーンに遷移する
    public void GashaButtonDown()
    {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("gasha");
    }

    public void XButtonDown()
    {
        GetComponent<AudioSource>().Play();
        Panel.SetActive(false);
        TextPanel.SetActive(false);
        tutorialText.SetActive(false);
        XButton.SetActive(false);

        SaveManager.shokaititle = 1;
    }
}
