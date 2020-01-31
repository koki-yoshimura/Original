using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {

    [SerializeField] private GameObject startButton;
    [SerializeField] private GameObject shopButton;
    [SerializeField] private GameObject gashaButton;
    [SerializeField] private GameObject shootingButton;
    [SerializeField] private GameObject title;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject goDialogRoot = null;
    [SerializeField] private CommonDialog commonDialog = null;


    private GameObject dialogObj = null;

    //スタートボタンを押すと非アクティブのボタンがアクティブとなる
    public void StartButtonDown()
    {
        audioSource.Play();

        startButton.SetActive(false);
        title.SetActive(false);
        shopButton.SetActive(true);
        gashaButton.SetActive(true);
        shootingButton.SetActive(true);

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
