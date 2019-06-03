using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour {

    GameObject shojicoin;

    // Use this for initialization
    void Start () {
        this.shojicoin = GameObject.Find("ShojiCoin");
		
	}
	
	// Update is called once per frame
	void Update () {
        this.shojicoin.GetComponent<Text>().text = "所持コイン " + GameDirector.savecoin;
	}

    //1ボタンを押し続けた場合の処理
    public void GetMyOneButtonDown()
    {
        if(GameDirector.savecoin >= 1)
        {
            Debug.Log(1);
            GameDirector.savecoin -= 1;
        }

    }

    //2ボタンを押し続けた場合の処理
    public void GetMyTwoButtonDown()
    {
        if (GameDirector.savecoin >= 2)
        {
            Debug.Log(1);
            GameDirector.savecoin -= 2;
        }
    }

    //3ボタンを押し続けた場合の処理
    public void GetMyThreeButtonDown()
    {
        if (GameDirector.savecoin >= 3)
        {
            Debug.Log(1);
            GameDirector.savecoin -= 3;
        }
    }

    //4ボタンを押し続けた場合の処理
    public void GetMyFourButtonDown()
    {
        if (GameDirector.savecoin >= 4)
        {
            Debug.Log(1);
            GameDirector.savecoin -= 4;
        }
    }

    //5ボタンを押し続けた場合の処理
    public void GetMyFiveButtonDown()
    {
        if (GameDirector.savecoin >= 5)
        {
            Debug.Log(1);
            GameDirector.savecoin -= 5;
        }
    }
}
