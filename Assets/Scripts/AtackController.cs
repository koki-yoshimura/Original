using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackController : MonoBehaviour {

    private float moveForce = 170.0f;//発射する弾の移動速度

    private Rigidbody myRigidbody;


    // Use this for initialization
    void Start () {

        this.myRigidbody = GetComponent<Rigidbody>();

        this.myRigidbody.AddForce(this.moveForce, 0, 0);//発射する弾の移動処理

}
	
	// Update is called once per frame
	void Update () {
        if (9 <= this.transform.position.x)//Atackが画面外に出たら削除する
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)//何かに当たった時に削除する(Coinはすり抜ける)
    {
        if (other.gameObject.tag != "Coin")
        {
            Destroy(gameObject);
        }

    }
}
