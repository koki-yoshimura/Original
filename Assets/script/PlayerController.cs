﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    
    private Rigidbody myRigidbody;

    private float moveForce = 14.0f; //上下に移動するための力

    [SerializeField] private AudioSource audioSource;

    [SerializeField] private GameObject player1;

    [SerializeField] private GameObject player2;

    [SerializeField] private GameObject player3;

    [SerializeField] private GameObject player4;

    [SerializeField] private GameObject atackPrefab;

    [SerializeField] private GameObject atackPrefab2;

    [SerializeField] private GameObject atackPrefab3;

    [SerializeField] private GameObject atackPrefab4;

    [SerializeField] private GameObject atackPrefab5;

    [SerializeField] private GameObject atackPrefab6;


    GameObject director;
    
    private bool isUButtonDown = false;//左ボタン押下の判定
    
    private bool isDButtonDown = false;//右ボタン押下の判定





    // Use this for initialization
    void Start () {

        //装備画面にて押されたチェックボックスによって装備が切り替わる
        if (WeponManager.SoubiA == 1)
        {
            player1.SetActive(true);
            player2.SetActive(false);
            player3.SetActive(false);
            player4.SetActive(false);
        }

        if (WeponManager.SoubiB == 1)
        {
            player1.SetActive(false);
            player2.SetActive(true);
            player3.SetActive(false);
            player4.SetActive(false);
        }

        if (WeponManager.SoubiC == 1)
        {
            player1.SetActive(false);
            player2.SetActive(false);
            player3.SetActive(true);
            player4.SetActive(false);
        }

        if (WeponManager.SoubiD == 1)
        {
            player1.SetActive(false);
            player2.SetActive(false);
            player3.SetActive(false);
            player4.SetActive(true);
        }

        this.director = GameObject.Find("GameDirector");

        this.myRigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
            //プレイヤーを矢印キーまたはボタンに応じて上下に移動させる
            if (this.isUButtonDown)
            {
                //上に移動
                this.myRigidbody.AddForce(0, this.moveForce, 0);
            }
            else if (this.isDButtonDown)
            {
                //下に移動
                this.myRigidbody.AddForce(0, -this.moveForce, 0);
            }
    }

    private void OnTriggerEnter(Collider other)//PlayerがCoinに当たった時に加算処理、Enemyに当たった時に減算処理を呼び出す
    {
        if (other.gameObject.tag == "Coin")
        {
            this.director.GetComponent<GameDirector>().GetCoin();

        }
        else if(other.gameObject.tag == "Enemy")
        {
            this.director.GetComponent<GameDirector>().Damage();
        }
    }

        public void GetMyAButtonDown()//発射ボタンを押した際に弾を生成する
    {
        audioSource.Play();

        //装備画面にて押されたチェックボックスによって攻撃が切り替わる
        if (WeponManager.SoubiE == 1)
        {
            GameObject atack = Instantiate(atackPrefab) as GameObject;
            atack.transform.position = new Vector3(this.transform.position.x + 1.5f, this.transform.position.y + 1.2f, 0);
        }

        if (WeponManager.SoubiF == 1)
        {
            GameObject atack = Instantiate(atackPrefab2) as GameObject;
            atack.transform.position = new Vector3(this.transform.position.x + 1.5f, this.transform.position.y + 1.2f, 0);
        }

        if (WeponManager.SoubiG == 1)
        {
            GameObject atack = Instantiate(atackPrefab3) as GameObject;
            atack.transform.position = new Vector3(this.transform.position.x + 1.5f, this.transform.position.y + 1.2f, 0);
        }

        if (WeponManager.SoubiH == 1)
        {
            GameObject atack = Instantiate(atackPrefab4) as GameObject;
            atack.transform.position = new Vector3(this.transform.position.x + 1.5f, this.transform.position.y + 1.2f, 0);
        }

        if (WeponManager.SoubiI == 1)
        {
            GameObject atack = Instantiate(atackPrefab5) as GameObject;
            atack.transform.position = new Vector3(this.transform.position.x + 1.5f, this.transform.position.y + 1.2f, 0);
        }

        if (WeponManager.SoubiJ == 1)
        {
            GameObject atack = Instantiate(atackPrefab6) as GameObject;
            atack.transform.position = new Vector3(this.transform.position.x + 1.5f, this.transform.position.y + 1.2f, 0);
        }
    }


    //上ボタンを押し続けた場合の処理
    public void GetMyUPButtonDown()
    {
        this.isUButtonDown = true;
    }
    //上ボタンを離した場合の処理
    public void GetMyUPButtonUp()
    {
        this.isUButtonDown = false;
    }

    //下ボタンを押し続けた場合の処理
    public void GetMyDownButtonDown()
    {
        this.isDButtonDown = true;
    }
    //下ボタンを離した場合の処理
    public void GetMyDownButtonUp()
    {
        this.isDButtonDown = false;
    }

}
