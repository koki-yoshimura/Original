using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour {

    Vector3 StartPos;

    private bool OneButtonDown = false;

    private bool TwoButtonDown = false;

    private bool ThreeButtonDown = false;

    private bool FourButtonDown = false;

    private bool FiveButtonDown = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            this.StartPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector3 EndPos = Input.mousePosition;

        }
		

	}

    //1ボタンを押し続けた場合の処理
    public void GetMyOneButtonDown()
    {
        this.OneButtonDown = true;
        Debug.Log(1);
    }

    //1ボタンを離した場合の処理
    public void GetMyOneButtonUp()
    {
        this.OneButtonDown = false;
    }

    //2ボタンを押し続けた場合の処理
    public void GetMyTwoButtonDown()
    {
        this.TwoButtonDown = true;
        Debug.Log(2);
    }

    //2ボタンを離した場合の処理
    public void GetMyTwoButtonUp()
    {
        this.TwoButtonDown = false;
    }

    //3ボタンを押し続けた場合の処理
    public void GetMyThreeButtonDown()
    {
        this.ThreeButtonDown = true;
        Debug.Log(3);
    }

    //3ボタンを離した場合の処理
    public void GetMyThreeButtonUp()
    {
        this.ThreeButtonDown = false;
    }

    //4ボタンを押し続けた場合の処理
    public void GetMyFourButtonDown()
    {
        this.FourButtonDown = true;
        Debug.Log(4);
    }

    //4ボタンを離した場合の処理
    public void GetMyFourButtonUp()
    {
        this.FourButtonDown = false;
    }

    //5ボタンを押し続けた場合の処理
    public void GetMyFiveButtonDown()
    {
        this.FiveButtonDown = true;
        Debug.Log(5);
    }

    //5ボタンを離した場合の処理
    public void GetMyFiveButtonUp()
    {
        this.FiveButtonDown = false;
    }
}
