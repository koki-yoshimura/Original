using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {

    [SerializeField] private AudioSource audioSource;

    [SerializeField] private GameObject StartButton;
    [SerializeField] private GameObject ShopButton;
    [SerializeField] private GameObject GashaButton;
    [SerializeField] private GameObject ShootingButton;
    [SerializeField] private GameObject Title;
    [SerializeField] private GameObject Panel;
    [SerializeField] private GameObject TextPanel;
    [SerializeField] private GameObject tutorialText;
    [SerializeField] private GameObject XButton;

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
            Panel.SetActive(true);
            TextPanel.SetActive(true);
            tutorialText.SetActive(true);
            XButton.SetActive(true);
        }
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
        GetComponent<AudioSource>().Play();
        Panel.SetActive(false);
        TextPanel.SetActive(false);
        tutorialText.SetActive(false);
        XButton.SetActive(false);

        SaveManager.shokaititle = 1;
    }
}
