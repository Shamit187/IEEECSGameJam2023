using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringToCallStopFollowCamera : MonoBehaviour
{
    [SerializeField] GameObject healthBar;
    StopFollowCamera stopFollowCamera;
    BoxCollider2D boxCollider2D;

    void Start()
    {
        stopFollowCamera = healthBar.GetComponent<StopFollowCamera>();
        boxCollider2D = healthBar.GetComponent<BoxCollider2D>();

        boxCollider2D.enabled = false;
    }
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player"){
            stopFollowCamera.FollowKillTrigger = true;
            boxCollider2D.enabled = true;
        }
    }
}
