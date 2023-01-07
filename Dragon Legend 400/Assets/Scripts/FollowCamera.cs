using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FollowCamera : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] CinemachineVirtualCamera followingCamera;
    SpriteRenderer mySpriteRenderer;

    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //Debug.Log(mySpriteRenderer.enabled);
        // Debug.Log(followingCamera.enabled);
        mySpriteRenderer.enabled = followingCamera.enabled;
    }
    void LateUpdate()
    {
        transform.position = new Vector3(followingCamera.transform.position.x, followingCamera.transform.position.y, 0f);
        
    }
}
