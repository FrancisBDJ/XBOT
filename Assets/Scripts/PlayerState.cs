using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        animator.SetInteger("PlayerState Int",0);
    }

    // Update is called once per frame
    void Update()
    {
        if  (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetInteger("PlayerState Int",1);
            Debug.Log(animator.GetInteger("PlayerState Int"));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetInteger("PlayerState Int",2);
            Debug.Log(animator.GetInteger("PlayerState Int"));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetInteger("PlayerState Int",3);
            Debug.Log(animator.GetInteger("PlayerState Int"));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetInteger("PlayerState Int",5);
            Debug.Log(animator.GetInteger("PlayerState Int"));
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.SetInteger("PlayerState Int",4);
            Debug.Log(animator.GetInteger("PlayerState Int"));
        }
        else
        {
            animator.SetInteger("PlayerState Int",0);
            Debug.Log(animator.GetInteger("PlayerState Int"));
        }
        
        
    }
}
