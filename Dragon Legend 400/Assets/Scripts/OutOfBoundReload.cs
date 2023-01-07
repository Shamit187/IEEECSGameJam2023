using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfBoundReload : MonoBehaviour
{
    [SerializeField] String SceneName;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag != "Player") return;
        Invoke("LoadScene", 1);
    }

    void LoadScene(){
        SceneManager.LoadScene(SceneName);
    }
}
