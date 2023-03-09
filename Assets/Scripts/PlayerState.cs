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
        animator.SetInteger("PlayerState",0);
    }

    // Update is called once per frame
    void Update()
    {
        if  (Input.GetKey(KeyCode.W))
        {
            animator.SetInteger("PlayerState",1);
            Debug.Log(animator.GetInteger("PlayerState"));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("PlayerState",2);
            Debug.Log(animator.GetInteger("PlayerState"));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("PlayerState",3);
            Debug.Log(animator.GetInteger("PlayerState"));
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetInteger("PlayerState",4);
            Debug.Log(animator.GetInteger("PlayerState"));
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            animator.SetInteger("PlayerState",5);
            Debug.Log(animator.GetInteger("PlayerState"));
        }
        else
        {
            animator.SetInteger("PlayerState",0);
            Debug.Log(animator.GetInteger("PlayerState"));
        }
    }
}
