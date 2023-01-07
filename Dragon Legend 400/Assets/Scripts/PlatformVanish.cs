using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformVanish : MonoBehaviour
{
    [SerializeField] float timeToDestory;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player"){
            Invoke("selfTerminate", timeToDestory);
        }
    }

    void selfTerminate(){
        Destroy(gameObject);
    }

}
