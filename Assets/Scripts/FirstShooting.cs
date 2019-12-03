using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FirstShooting : MonoBehaviour {

    [SerializeField] private AudioSource audioSource;

    public void XButtonDown()
    {
        audioSource.Play();

        SceneManager.LoadScene("Shooting");

        SaveManager.FirstShooting = 1;
    }
}
