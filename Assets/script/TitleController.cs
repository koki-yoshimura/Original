using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {

    [SerializeField] private GameObject goDialogRoot = null;

    public GameObject StartButton;
    public GameObject ShopButton;
    public GameObject GashaButton;
    public GameObject ShootingButton;
    public GameObject Title;
    public GameObject Panel;
    public GameObject TextPanel;
    public GameObject tutorialText;
    public GameObject XButton;

    public GameObject dialog;

    // Use this for initialization
    void Start () {
        var dialog = (GameObject)Resources.Load("Prefabs/CommonDialog");
        Instantiate(dialog, goDialogRoot.transform, worldPositionStays: false);

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
