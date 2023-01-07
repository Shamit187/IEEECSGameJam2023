using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerLife : MonoBehaviour
{
    // Start is called before the first frame update
    bool PlayerIn;
    [SerializeField] GameObject MainCharacter;
    [SerializeField] float KillingSpeed;
    [SerializeField] AudioSource emergencySound;
    PlayerLife playerLife;

    float actualKilingSpeed;

    void disableAttack()
    {
        actualKilingSpeed = 0;
    }

    void enableAttack()
    {
        actualKilingSpeed = KillingSpeed;
    }



    void Start()
    {
        PlayerIn = false;
        playerLife = MainCharacter.GetComponent<PlayerLife>();
        actualKilingSpeed = KillingSpeed;
    }

    void Update() {
        if(PlayerIn){
            playerLife.Life -= actualKilingSpeed * Time.deltaTime;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player") {
            PlayerIn = true;
            if(!other.gameObject.GetComponent<PlayerLife>().Immortal)
                emergencySound.Play();
        }
        if(other.gameObject.tag == "Dancer") disableAttack();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player") PlayerIn = false;
        if(other.gameObject.tag == "Dancer") enableAttack();
    }
}
