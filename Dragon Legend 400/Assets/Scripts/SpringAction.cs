using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringAction : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float SpringForce;
    [SerializeField] AudioSource SpringSound;
    Animator myAnimator;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag != "Player") return;
        Rigidbody2D playerRigidBody = other.gameObject.GetComponent<Rigidbody2D>();
        playerRigidBody.velocity += new Vector2(playerRigidBody.velocity.x, SpringForce);
        myAnimator.SetTrigger("IsTouchingPlayer");
        SpringSound.Play();

    }
}
