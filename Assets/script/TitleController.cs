using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {

    [SerializeField] private GameObject StartButton;
    [SerializeField] private GameObject ShopButton;
    [SerializeField] private GameObject GashaButton;
    [SerializeField] private GameObject ShootingButton;
    [SerializeField] private GameObject Title;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject goDialogRoot = null;
    [SerializeField] private CommonDialog commonDialog = null;


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

            //var dialog = (GameObject)Resources.Load("Prefabs/CommonDialog");
            commonDialog = Instantiate(commonDialog, goDialogRoot.transform, worldPositionStays: false);


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

}
