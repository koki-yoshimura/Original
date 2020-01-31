using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
	
    float baseXPos = 6; // 基準となるx座標
    float baseYPos = 4; // 基準となるy座標

    float xOffset = 0.5f; // X座標の生成間隔
    float yOffset = 1.5f; // Y軸の生成間隔

    float remainingTime = 5.0f; // Enemyを生成するまでの時間

    [SerializeField] private GameObject enemyPrefab;


    void Update()
{
    // 1秒１秒減らしていく
    remainingTime -= Time.deltaTime;

    // ５秒経過したら
    if (remainingTime <= 0)
    {

        // ２択のランダムな数
        int rand = Random.Range(0, 2);

        if (rand == 0)
        {
            GenerateATypeEnemys();
        }
        else if (rand == 1)
        {
            GenerateBTypeEnemys();
        }

        remainingTime = 5.0f;
    }
}

void GenerateATypeEnemys()//パターンAのEnemy表示
{
    int[]xpos = new int[] {2, 1, 0, 1, 2};

     for (int i = 0; i< 5; i++) { 
        GameObject obj = Instantiate(enemyPrefab) as GameObject;
        obj.transform.position = new Vector3(baseXPos + xOffset * xpos[i], baseYPos - yOffset * i, 0);
     }
    
}

void GenerateBTypeEnemys()//パターンBのEnemy表示
    {
    for (int i = 0; i < 5; i++) {
        GameObject obj = Instantiate(enemyPrefab) as GameObject;
        obj.transform.position = new Vector3(baseXPos - xOffset * i, baseYPos - yOffset * i, 0);
    }
}
}