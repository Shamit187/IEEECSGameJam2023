using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class CarMovement : MonoBehaviour
{   
    bool isPlayerInside;
    Vector2 moveInput;
    Collider2D myCollider2D;
    Rigidbody2D myRigidbody2D;
    PlayerInput playerInput;
    [SerializeField] float baseVelocity;

    [SerializeField] CinemachineVirtualCamera carCamera;
    [SerializeField] CinemachineVirtualCamera playerCamera;

    // Start is called before the first frame update
    void Start()
    {
        isPlayerInside = false;
        myCollider2D = GetComponent<Collider2D>();
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myRigidbody2D.gravityScale = 0;
        carCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayerInside)
        {   
            run();
            flipSprite();
        }
    }

    void run() {
        Vector2 carVelocity = new Vector2(moveInput.x * baseVelocity,myRigidbody2D.velocity.y);
        myRigidbody2D.velocity = carVelocity;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player"){
            isPlayerInside = true;
            Destroy(other.gameObject);
            this.gameObject.AddComponent<PlayerInput>();
            playerInput = GetComponent<PlayerInput>();
            myRigidbody2D.gravityScale = 1;
            playerCamera.enabled = false;
            carCamera.enabled = true;
        }
    }

    void OnMove(InputValue value) {
        moveInput = value.Get<Vector2>();
        if(isPlayerInside){
            Vector2 playerVelcoity = new Vector2(moveInput.x * baseVelocity, myRigidbody2D.velocity.y);
            myRigidbody2D.velocity = playerVelcoity;
        }
    }

    void flipSprite(){
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidbody2D.velocity.x) > Mathf.Epsilon;
        if(playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(-1f * Mathf.Sign(myRigidbody2D.velocity.x), 1f);
            
        }
    }
}
