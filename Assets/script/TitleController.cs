using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {

    [SerializeField] private AudioSource audioSource;

    [SerializeField] private GameObject startButton;
    [SerializeField] private GameObject shopButton;
    [SerializeField] private GameObject gashaButton;
    [SerializeField] private GameObject shootingButton;
    [SerializeField] private GameObject title;
    [SerializeField] private GameObject tutorialpanel;

    public void StartButtonDown()
    {
        audioSource.Play();

        startButton.SetActive(false);
        title.SetActive(false);
        shopButton.SetActive(true);
        gashaButton.SetActive(true);
        shootingButton.SetActive(true);

        if (SaveManager.shokaititle == 0)
        {
            tutorialpanel.SetActive(true);
        }
    }

    public void ShootingButtonDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("soubi");
    }

    public void ShopButtonDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("shop");
    }

    public void GashaButtonDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("gasha");
    }

    public void XButtonDown()
    {
        audioSource.Play();
        tutorialpanel.SetActive(false);

        SaveManager.shokaititle = 1;
    }
}
