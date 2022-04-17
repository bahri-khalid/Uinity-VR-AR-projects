using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
     Animator animator;
        int isWalkingHash;
        int isRunningHash;
        int leftWalkingHash;
        int rightWalkingHash;
        int leftRunningHash;
        int rightRunningHash;
        int fastRunningHash;
    // Start is called before the first frame update
    void Start()
    {
         animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        leftWalkingHash = Animator.StringToHash("leftWalking");
        rightWalkingHash = Animator.StringToHash("rightWalking");
        leftRunningHash = Animator.StringToHash("leftRunning");
        rightRunningHash = Animator.StringToHash("rightRunning");
        fastRunningHash = Animator.StringToHash("fastRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isRunning = animator.GetBool(isRunningHash);
        bool leftWalking = animator.GetBool(leftWalkingHash);
        bool rightWalking = animator.GetBool(rightWalkingHash);
        bool leftRunning = animator.GetBool(leftRunningHash);
        bool rightRunning = animator.GetBool(rightRunningHash);
        bool fastRunning = animator.GetBool(fastRunningHash);

        bool w = Input.GetKey("w");
        bool e = Input.GetKey("e");
        bool q = Input.GetKey("q");
        bool s = Input.GetKey("s");
        bool d = Input.GetKey("d");
        bool a = Input.GetKey("a");
        bool fastRunPress = Input.GetKey("left shift");

        // for walking 
        if(!isWalking && w)
        {
            animator.SetBool("isWalking",true);
        }

        if(isWalking && !w )
        {
            animator.SetBool("isWalking",false);
        }
        // for right Walking
        if(!rightWalking && e && isWalking)
        {
            animator.SetBool("rightWalking",true);
        }

        if(rightWalking && !e && isWalking )
        {
            animator.SetBool("rightWalking",false);
        }

        // for left Walking

        if(!leftWalking && q && isWalking)
        {
            animator.SetBool("leftWalking",true);
        }

        if(leftWalking && !q && isWalking )
        {
            animator.SetBool("leftWalking",false);
        }

        // for Running 
        if(!isRunning && s)
        {
            animator.SetBool("isRunning",true);
        }

        if(isRunning && !s )
        {
            animator.SetBool("isRunning",false);
        }
        // for right Running
        if(!rightRunning && d && isRunning)
        {
            animator.SetBool("rightRunning",true);
        }

        if(rightRunning && !d && isRunning )
        {
            animator.SetBool("rightRunning",false);
        }

        // for left Running

        if(!leftRunning && a && isRunning)
        {
            animator.SetBool("leftRunning",true);
        }

        if(leftRunning && !a && isRunning )
        {
            animator.SetBool("leftRunning",false);
        }

        // for running
        if(!fastRunning && fastRunPress)
        {
            animator.SetBool("fastRunning",true);
        }

        if(fastRunning  && !fastRunPress)
        {
            animator.SetBool("fastRunning",false);
        }
    }
}
