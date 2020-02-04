using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoxGacha : MonoBehaviour
{

    GameObject possessionCoin;

    public static int Gasha1 = 0;
    public static int Gasha2 = 0;
    public static int Gasha3 = 0;

    [SerializeField] private GameObject shortagePanel;
    [SerializeField] private GameObject shortageText;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject textPanel;
    [SerializeField] private GameObject moveButton;
    [SerializeField] private GameObject gashaButton;
    [SerializeField] private GameObject endPanel;
    [SerializeField] private GameObject endText;
    [SerializeField] private GameObject tutorialText;
    [SerializeField] private GameObject xButton;
    [SerializeField] private GameObject text2;
    [SerializeField] private GameObject text3;
    [SerializeField] private GameObject text4;
    [SerializeField] private GameObject losingText;
    [SerializeField] private AudioSource audioSource;


    List<string> m_gachaItems = new List<string>() { "a", "b", "b", "c", "c", "d", "d", "d" };

    void Start()
    {
        this.possessionCoin = GameObject.Find("PossessionCoin");

        if (SaveManager.FirstGasha == 0)
        {
            panel.SetActive(true);
            textPanel.SetActive(true);
            tutorialText.SetActive(true);
            xButton.SetActive(true);
        }

        if (m_gachaItems.Count < 1)
        {
            endPanel.SetActive(true);
            endText.SetActive(true);
            return;
        }

    }

    void Update()
    {
        this.possessionCoin.GetComponent<Text>().text = "所持コイン " + GameDirector.SaveCoin;

    }

        public void Lottery()
    {
        audioSource.Play();

        int i = Random.Range(0, m_gachaItems.Count);

        if (GameDirector.SaveCoin >= 10)
        {
            switch (m_gachaItems[i])
            {
                case "a":

                        Gasha1 = 1;
                        GameDirector.SaveCoin -= 10;

                        panel.SetActive(true);
                        textPanel.SetActive(true);
                        moveButton.SetActive(true);
                        text4.SetActive(true);


                    break;

                case "b":

                        Gasha2 = 1;
                        GameDirector.SaveCoin -= 10;

                        panel.SetActive(true);
                        textPanel.SetActive(true);
                        moveButton.SetActive(true);
                        text3.SetActive(true);

                    break;

                case "c":

                        Gasha3 = 1;
                        GameDirector.SaveCoin -= 10;

                        panel.SetActive(true);
                        textPanel.SetActive(true);
                        moveButton.SetActive(true);
                        text2.SetActive(true);

                    break;

                case "d":

                        GameDirector.SaveCoin -= 10
                            ;

                        panel.SetActive(true);
                        textPanel.SetActive(true);
                        moveButton.SetActive(true);
                        losingText.SetActive(true);

                    break;

            }
        }
        else
        {
            shortagePanel.SetActive(true);
            shortageText.SetActive(true);

        }

        string destroy = m_gachaItems[i];

        for (int y = 0; y < m_gachaItems.Count; y++)
        {
            if (destroy == m_gachaItems[y])
            {
                m_gachaItems.RemoveAt(y);   // 消す
                y -= 1;
            }
        }
    }

    public void ReturnButtonDown()
    {
        audioSource.Play();
        SceneManager.LoadScene("Title");
    }

    public void susumuButtonDown()
    {
        audioSource.Play();
        panel.SetActive(false);
        textPanel.SetActive(false);
        moveButton.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        losingText.SetActive(false);

        if (m_gachaItems.Count < 1)
        {
            panel.SetActive(false);
            endPanel.SetActive(true);
            endText.SetActive(true);
            return;
        }

    }

    public void XButtonDown()
    {
        audioSource.Play();
        panel.SetActive(false);
        textPanel.SetActive(false);
        tutorialText.SetActive(false);
        xButton.SetActive(false);

        SaveManager.FirstGasha = 1;
    }

}
