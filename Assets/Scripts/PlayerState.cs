using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public Animator animator;
    public float speed = 0.01f;
    public Transform xbotTransform;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        xbotTransform = this.transform;
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
            //animator.SetInteger("PlayerState", 2);
            xbotTransform.Rotate(0,60 * speed * Time.deltaTime,0);
            Debug.Log(animator.GetInteger("PlayerState"));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //animator.SetInteger("PlayerState",3);
            xbotTransform.Rotate(0,-60 * speed * Time.deltaTime,0);
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
