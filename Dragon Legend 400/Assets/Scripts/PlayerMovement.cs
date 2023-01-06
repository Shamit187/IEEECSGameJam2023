using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D myRigidbody2D;
    Collider2D myCollider2D;
    Vector2 moveInput;
    Animator myAnimator;
    [SerializeField] float baseVelocity;
    [SerializeField] float baseJump;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myCollider2D = GetComponent<Collider2D>();
    }

    void Update()
    {
        run();
        flipSprite();
        if(!(Mathf.Abs(myRigidbody2D.velocity.y) > Mathf.Epsilon))
            myAnimator.SetBool("IsJumping", false);
    }

    void run()
    {
        Vector2 playerVelcoity = new Vector2(moveInput.x * baseVelocity,myRigidbody2D.velocity.y);
        myRigidbody2D.velocity = playerVelcoity;
    }

    void OnMove(InputValue value){
        moveInput = value.Get<Vector2>();
    }

    void flipSprite(){
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidbody2D.velocity.x) > Mathf.Epsilon;
        if(playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(myRigidbody2D.velocity.x), 1f);
            myAnimator.SetBool("IsRunning", true);
        }
        else
        {
            myAnimator.SetBool("IsRunning", false);
        }
    }

    void OnJump(InputValue value){
        if(value.isPressed && myCollider2D.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            myRigidbody2D.velocity += new Vector2(0f, baseJump);
            myAnimator.SetBool("IsJumping", true);
        }
    }
}
