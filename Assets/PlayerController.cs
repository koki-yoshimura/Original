using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //プレイヤーを移動させるコンポーネントを入れる
    private Rigidbody myRigidbody;

    //上下に移動するための力
    private float moveForce = 500.0f;

    //左ボタン押下の判定
    private bool isUButtonDown = false;
    
    //右ボタン押下の判定
    private bool isDButtonDown = false;


    // Use this for initialization
    void Start () {
		
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
