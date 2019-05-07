﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public GameObject coinPrefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        GameObject coin = Instantiate(coinPrefab) as GameObject;
        coin.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0);
    }
}
