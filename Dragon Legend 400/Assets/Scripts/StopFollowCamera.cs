using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopFollowCamera : MonoBehaviour
{
    // Start is called before the first frame update
    FollowCamera myFollowCamera;
    public bool FollowKillTrigger;
    void Start()
    {
        myFollowCamera = GetComponent<FollowCamera>();
        FollowKillTrigger = false;
        //need to set a trigger to remove UI
    }

    // Update is called once per frame
    void Update()
    {
        if(FollowKillTrigger && myFollowCamera.enabled) myFollowCamera.enabled = false;
        else if(!FollowKillTrigger && !myFollowCamera.enabled) myFollowCamera.enabled = true;
    }
}
