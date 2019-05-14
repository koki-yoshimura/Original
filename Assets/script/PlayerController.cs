using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    
    private Rigidbody myRigidbody;

    private float moveForce = 14.0f; //上下に移動するための力

    public GameObject atackPrefab;

    GameObject director;
    
    private bool isUButtonDown = false;//左ボタン押下の判定
    
    private bool isDButtonDown = false;//右ボタン押下の判定




    // Use this for initialization
    void Start () {

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

    private void OnTriggerEnter(Collider other)//PlayerがCoinに当たった時に加算処理を呼び出す
    {
        if (other.gameObject.tag == "Coin")
        {
            this.director.GetComponent<GameDirector>().GetCoin();
        }
    }

        public void GetMyAButtonDown()//発射ボタンを押した際に弾を生成する
    {
        GameObject atack = Instantiate(atackPrefab) as GameObject;
        atack.transform.position = new Vector3(this.transform.position.x + 1.5f, this.transform.position.y, 0);
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
