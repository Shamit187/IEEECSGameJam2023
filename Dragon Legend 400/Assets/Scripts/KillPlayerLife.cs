using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerLife : MonoBehaviour
{
    // Start is called before the first frame update
    bool PlayerIn;
    [SerializeField] GameObject MainCharacter;
    [SerializeField] float KillingSpeed;
    PlayerLife playerLife;


    void Start()
    {
        PlayerIn = false;
        playerLife = MainCharacter.GetComponent<PlayerLife>();
    }

    void Update() {
        if(PlayerIn){
            playerLife.Life -= KillingSpeed * Time.deltaTime;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player") PlayerIn = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player") PlayerIn = false;
    }
}
