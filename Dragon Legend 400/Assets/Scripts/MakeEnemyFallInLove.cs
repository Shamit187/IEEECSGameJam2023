using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeEnemyFallInLove : MonoBehaviour
{
    Animator myAnimator;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "FireRange"){
            Animator enemyAnimator = other.GetComponentInParent<Animator>();
            enemyAnimator.SetBool("InLove", true);
            myAnimator.SetBool("IsDancing", true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "FireRange"){
            Animator enemyAnimator = other.GetComponentInParent<Animator>();
            enemyAnimator.SetBool("InLove", false);
            myAnimator.SetBool("IsDancing", false);
        }
    }
}
