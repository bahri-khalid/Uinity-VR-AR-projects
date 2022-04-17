using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityScript : MonoBehaviour
{
    Animator animator;
    int blendHash;
    int blendHash2;
    float velocity = 0.0f;
    float velocity2 = 0.0f;
    public float acceleration = 0.0001f;
    public float deceleration = 0.00005f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        blendHash = Animator.StringToHash("Blend");
        blendHash2 = Animator.StringToHash("Blend2");

    }

    // Update is called once per frame
    void Update()
    {
        bool move = Input.GetKey("w");
        bool turn= Input.GetKey("e");
        if(move && velocity<1.95f)
        {
            velocity+= Time.deltaTime*acceleration;
        }
        if(!move && velocity>0.05f)
        {
            velocity-= Time.deltaTime*deceleration;
        }
        if(turn && velocity2<0.95f)
        {
            velocity2+=Time.deltaTime*acceleration;
        }
        if(!turn && velocity2 >0.05f)
        {
            velocity2-=Time.deltaTime*deceleration;
        }
        animator.SetFloat(blendHash,velocity);
        animator.SetFloat(blendHash2,velocity2);
    }
}
