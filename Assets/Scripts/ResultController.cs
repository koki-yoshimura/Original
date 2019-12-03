using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultController : MonoBehaviour {

    [SerializeField] private Text textResult = null;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioSource audioSource2;

    // Use this for initialization
    void  Start(){  

        if (GameDirector.IsClear)
        {
            // クリアしたときの処理
            textResult.text = "Clear";
            audioSource.Play();
        }
        else
        {
            // ゲームオーバーの時の処理
            textResult.text ="Game Over";
            audioSource2.Play();
        }


    }

    public void TitleButtonDown()
    {
        SceneManager.LoadScene("Title");
    }
}
