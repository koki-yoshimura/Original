using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    [SerializeField] private GameObject coinPrefab;
    private float moveForce = 170.0f;//Enemyの移動速度

    private Rigidbody myRigidbody;

    // Use this for initialization
    void Start () {

        this.myRigidbody = GetComponent<Rigidbody>();

        this.myRigidbody.AddForce(-this.moveForce, 0, 0);//Enemyの移動処理

    }
	
	// Update is called once per frame
	void Update () {
        if(-9 >= this.transform.position.x)//Enemyが画面外に出たら削除する
        {
            Destroy(gameObject);
        }
		
	}

    private void OnTriggerEnter(Collider other)//Playerに撃破された時にCoinを表示する
    {

        if (other.gameObject.tag == "Atack")
        {
            Destroy(gameObject);
            GameObject coin = Instantiate(coinPrefab) as GameObject;
            coin.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0);

        }
    }

}
