using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public float Life;
    public bool Immortal;

    [SerializeField] AudioSource PlayerDeathSound;
    void Start()
    {
        Life = 1;
        Immortal = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Immortal) Life = 1;
        if(Life < 0) KillYourself();
    }

    void KillYourself(){
        PlayerDeathSound.Play();
        Invoke("ReloadScene", .1f);
    }

    void ReloadScene(){
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
