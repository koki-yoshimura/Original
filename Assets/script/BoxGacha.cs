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

    public GameObject tarinaiPanel;
    public GameObject tarinaiText;

    public GameObject Panel;
    public GameObject TextPanel;
    public GameObject susumuButton;
    public GameObject GashaButton;
    public GameObject endPanel;
    public GameObject endText;
    public GameObject tutorialText;
    public GameObject XButton;

    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject hazuretext;


    List<string> m_gachaItems = new List<string>() { "a", "b", "b", "c", "c", "d", "d", "d" };

    void Start()
    {
        this.shojicoin = GameObject.Find("ShojiCoin");

        if (SaveManager.shokaigasha == 0)
        {
            Panel.SetActive(true);
            TextPanel.SetActive(true);
            tutorialText.SetActive(true);
            XButton.SetActive(true);
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
        GetComponent<AudioSource>().Play();

        int i = Random.Range(0, m_gachaItems.Count);

        if (GameDirector.savecoin >= 10)
        {
            switch (m_gachaItems[i])
            {
                case "a":

                        Gasha1 = 1;
                        GameDirector.savecoin -= 10;

                        Panel.SetActive(true);
                        TextPanel.SetActive(true);
                        susumuButton.SetActive(true);
                        text4.SetActive(true);


                    break;

                case "b":

                        Gasha2 = 1;
                        GameDirector.savecoin -= 10;

                        Panel.SetActive(true);
                        TextPanel.SetActive(true);
                        susumuButton.SetActive(true);
                        text3.SetActive(true);

                    break;

                case "c":

                        Gasha3 = 1;
                        GameDirector.savecoin -= 10;

                        Panel.SetActive(true);
                        TextPanel.SetActive(true);
                        susumuButton.SetActive(true);
                        text2.SetActive(true);

                    break;

                case "d":

                        GameDirector.savecoin -= 10
                            ;

                        Panel.SetActive(true);
                        TextPanel.SetActive(true);
                        susumuButton.SetActive(true);
                        hazuretext.SetActive(true);

                    break;

            }
        }
        else
        {
            tarinaiPanel.SetActive(true);
            tarinaiText.SetActive(true);

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
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("title");
    }

    public void susumuButtonDown()
    {
        GetComponent<AudioSource>().Play();
        Panel.SetActive(false);
        TextPanel.SetActive(false);
        susumuButton.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        hazuretext.SetActive(false);

        if (m_gachaItems.Count < 1)
        {
            Panel.SetActive(false);
            endPanel.SetActive(true);
            endText.SetActive(true);
            return;
        }

    }

    public void XButtonDown()
    {
        GetComponent<AudioSource>().Play();
        Panel.SetActive(false);
        TextPanel.SetActive(false);
        tutorialText.SetActive(false);
        XButton.SetActive(false);

        SaveManager.shokaigasha = 1;
    }

}
