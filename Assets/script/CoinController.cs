using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

    private float moveForce = 100.0f;//Coinの移動速度

    private Rigidbody myRigidbody;

    // Use this for initialization
    void Start () {

        this.myRigidbody = GetComponent<Rigidbody>();

        this.myRigidbody.AddForce(-this.moveForce, 0, 0);//Coinの移動処理

    }
	
	// Update is called once per frame
	void Update () {
        if (-9 >= this.transform.position.x)//Coinが画面外に出たら削除する
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)//Playerに当たった時に削除する
    {
        if (other.gameObject.tag == "test")
        {
            Destroy(gameObject);
        }
    }
}
