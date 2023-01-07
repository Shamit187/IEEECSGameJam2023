using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public float Life;
    void Start()
    {
        Life = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Life < 0) KillYourself();
    }

    void KillYourself(){
        Invoke("ReloadScene", .1f);
    }

    void ReloadScene(){
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
