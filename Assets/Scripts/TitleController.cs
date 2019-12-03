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
    [SerializeField] private GameObject tutorialPanel;

    public void StartButtonDown()
    {
        audioSource.Play();

        startButton.SetActive(false);
        title.SetActive(false);
        shopButton.SetActive(true);
        gashaButton.SetActive(true);
        shootingButton.SetActive(true);

        if (SaveManager.FirstTitle == 0)
        {
            tutorialPanel.SetActive(true);
        }
    }

    public void ShootingButtonDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("Wepon");
    }

    public void ShopButtonDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("Shop");
    }

    public void GashaButtonDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("Gasha");
    }

    public void XButtonDown()
    {
        audioSource.Play();
        tutorialPanel.SetActive(false);

        SaveManager.FirstTitle = 1;
    }
}
