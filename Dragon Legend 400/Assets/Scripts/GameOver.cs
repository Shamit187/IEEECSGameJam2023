using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] string NextLevel;
    [SerializeField] AudioSource GameOverSound;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag != "Player") return;
        GameOverSound.Play();
        Invoke("LoadScene", 1f);
    }

    void LoadScene(){
        SceneManager.LoadScene(NextLevel);
    }
}
