using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rizarutoController : MonoBehaviour {

    GameObject rizaruto;
    GameObject clearse;
    GameObject gameoverse;

    // Use this for initialization
    void  Start(){  

        this.rizaruto = GameObject.Find("Text");
        this.clearse = GameObject.Find("clearse");
        this.gameoverse = GameObject.Find("gameoverse");


        if (GameDirector.IsClear == true)
        {
            // クリアしたときの処理
            this.rizaruto.GetComponent<Text>().text = "Clear";
            this.clearse.GetComponent<AudioSource>().Play();
        }
        else
        {
            // ゲームオーバーの時の処理
            this.rizaruto.GetComponent<Text>().text = "Game Over";
            this.gameoverse.GetComponent<AudioSource>().Play();
        }


    }

    // Update is called once per frame
    void Update () {

    }

    public void TitleButtonDown()
    {
        SceneManager.LoadScene("title");
    }
}
