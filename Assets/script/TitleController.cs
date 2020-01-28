using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour {

    [SerializeField] private GameObject StartButton;
    [SerializeField] private GameObject ShopButton;
    [SerializeField] private GameObject GashaButton;
    [SerializeField] private GameObject ShootingButton;
    [SerializeField] private GameObject Title;

    [SerializeField] private AudioSource audioSource;

    [SerializeField] private GameObject goDialogRoot = null;

    GameObject  XButton;

    private GameObject dialogObj = null;

    //スタートボタンを押すと非アクティブのボタンがアクティブとなる
    public void StartButtonDown()
    {
        audioSource.Play();

        StartButton.SetActive(false);
        Title.SetActive(false);
        ShopButton.SetActive(true);
        GashaButton.SetActive(true);
        ShootingButton.SetActive(true);

            var dialog = (GameObject)Resources.Load("Prefabs/CommonDialog");
            dialogObj = Instantiate(dialog, goDialogRoot.transform, worldPositionStays: false);
            //this.XButton = GameObject.Find("XButton");
            //this.XButton.AddComponent<Button>();
            //this.XButton.onClick.AddListener(XButtonDown);


    }

    //soubiボタンを押してsoubiシーンに遷移する
    public void ShootingButtonDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("soubi");
    }

    //shopボタンを押してshopシーンに遷移する
    public void ShopButtonDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("shop");
    }

    //gashaボタンを押してgashaシーンに遷移する
    public void GashaButtonDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("gasha");
    }

    public void XButtonDown()
    {
        audioSource.Play();
        //Panel.SetActive(false);
        //TextPanel.SetActive(false);
        //tutorialText.SetActive(false);
        //XButton.SetActive(false);
        Destroy(dialogObj);


        SaveManager.shokaititle = 1;
    }
}
