using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] string NextLevel;
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag != "Player") return;
        Invoke("LoadScene", 0.3f);
    }

    void LoadScene(){
        SceneManager.LoadScene(NextLevel);
    }
}
