using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarMovement : MonoBehaviour
{   
    bool isPlayerInside;
    Vector2 moveInput;
    Collider2D myCollider2D;
    Rigidbody2D myRigidbody2D;
    PlayerInput playerInput;
    [SerializeField] float baseVelocity;
    

    // Start is called before the first frame update
    void Start()
    {
        isPlayerInside = false;
        myCollider2D = GetComponent<Collider2D>();
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myRigidbody2D.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayerInside)
        {   
            run();
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
            // TODO: Add fuchu player action to playerInput.
            myRigidbody2D.gravityScale = 1;
        
        }
    }

    void OnMove(InputValue value) {
        moveInput = value.Get<Vector2>();
    }
}
