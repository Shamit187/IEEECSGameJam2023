using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfTermination : MonoBehaviour
{
    [SerializeField] GameObject MainCharacter;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player"){
            PlayerLife playerLife = MainCharacter.GetComponent<PlayerLife>();
            playerLife.Immortal = true;
            Destroy(gameObject);
        }
    }
}
