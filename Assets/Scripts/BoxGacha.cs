using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoxGacha : MonoBehaviour
{

    GameObject shojicoin;

    public static int Gasha1 = 0;
    public static int Gasha2 = 0;
    public static int Gasha3 = 0;

    [SerializeField] private AudioSource audioSource;

    [SerializeField] private GameObject deficientPanel;
    [SerializeField] private GameObject deficientText;

    [SerializeField] private GameObject  panel;
    [SerializeField] private GameObject  textPanel;
    [SerializeField] private GameObject moveOnButton;
    [SerializeField] private GameObject gashaButton;
    [SerializeField] private GameObject endPanel;
    [SerializeField] private GameObject endText;
    [SerializeField] private GameObject tutorialText;
    [SerializeField] private GameObject xButton;

    [SerializeField] private GameObject text2;
    [SerializeField] private GameObject text3;
    [SerializeField] private GameObject text4;
    [SerializeField] private GameObject hazuretext;


    List<string> m_gachaItems = new List<string>() { "a", "b", "b", "c", "c", "d", "d", "d" };

    void Start()
    {
        this.shojicoin = GameObject.Find("ShojiCoin");

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
        this.shojicoin.GetComponent<Text>().text = "所持コイン " + GameDirector.savecoin;

    }

        public void Lottery()
    {
        audioSource.Play();

        int i = Random.Range(0, m_gachaItems.Count);

        if (GameDirector.savecoin >= 10)
        {
            switch (m_gachaItems[i])
            {
                case "a":

                        Gasha1 = 1;
                        GameDirector.savecoin -= 10;

                        panel.SetActive(true);
                        textPanel.SetActive(true);
                        moveOnButton.SetActive(true);
                        text4.SetActive(true);


                    break;

                case "b":

                        Gasha2 = 1;
                        GameDirector.savecoin -= 10;

                        panel.SetActive(true);
                        textPanel.SetActive(true);
                        moveOnButton.SetActive(true);
                        text3.SetActive(true);

                    break;

                case "c":

                        Gasha3 = 1;
                        GameDirector.savecoin -= 10;

                        panel.SetActive(true);
                        textPanel.SetActive(true);
                        moveOnButton.SetActive(true);
                        text2.SetActive(true);

                    break;

                case "d":

                        GameDirector.savecoin -= 10
                            ;

                        panel.SetActive(true);
                        textPanel.SetActive(true);
                        moveOnButton.SetActive(true);
                        hazuretext.SetActive(true);

                    break;

            }
        }
        else
        {
            deficientPanel.SetActive(true);
            deficientText.SetActive(true);

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
        SceneManager.LoadScene("title");
    }

    public void susumuButtonDown()
    {
        audioSource.Play();
        panel.SetActive(false);
        textPanel.SetActive(false);
        moveOnButton.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        hazuretext.SetActive(false);

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
