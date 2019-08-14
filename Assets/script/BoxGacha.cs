using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoxGacha : MonoBehaviour
{
    int coin = 100;

    GameObject shojicoin;

    public static int Gasha1 = 0;
    public static int Gasha2 = 0;
    public static int Gasha3 = 0;
    public static int Gasha4 = 0;

    public GameObject Panel;
    public GameObject TextPanel;
    public GameObject susumuButton;


    List<string> m_gachaItems = new List<string>() { "a", "b", "b", "c", "c", "d", "d", "d" };

    void Start()
    {
        this.shojicoin = GameObject.Find("ShojiCoin");

    }

    void Update()
    {
        this.shojicoin.GetComponent<Text>().text = "所持コイン " + coin;
    }

        public void Lottery()
    {
        GetComponent<AudioSource>().Play();

        if (m_gachaItems.Count < 1)
        {
            Debug.Log("ガチャの中身がありません");
            return;
        }

        int i = Random.Range(0, m_gachaItems.Count);


        switch (m_gachaItems[i])
        {
            case "a":
                if (coin >= 10)
                {
                    Gasha1 = 1;
                    coin -= 1;

                    Panel.SetActive(true);
                    TextPanel.SetActive(true);
                    susumuButton.SetActive(true);

                    Debug.Log(m_gachaItems[i] + "を引きました");
                }
                break;

            case "b":
                if (coin >= 10)
                {
                    Gasha2 = 1;
                    coin -= 1;

                    Panel.SetActive(true);
                    TextPanel.SetActive(true);
                    susumuButton.SetActive(true);

                    Debug.Log(m_gachaItems[i] + "を引きました");
                }
                break;

            case "c":
                if (coin >= 10)
                {
                    Gasha3 = 1;
                    coin -= 1;

                    Panel.SetActive(true);
                    TextPanel.SetActive(true);
                    susumuButton.SetActive(true);

                    Debug.Log(m_gachaItems[i] + "を引きました");
                }
                break;

            case "d":
                if (coin >= 10)
                {
                    Gasha4 = 1;
                    coin -= 1;

                    Panel.SetActive(true);
                    TextPanel.SetActive(true);
                    susumuButton.SetActive(true);

                    Debug.Log(m_gachaItems[i] + "を引きました");
                }
                break;

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

    }

}
