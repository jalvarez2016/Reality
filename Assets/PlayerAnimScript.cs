using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimScript : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            animator.SetBool("LefttWalk", true);
        } else {
            animator.SetBool("LeftWalk", false);
        }
        if(Input.GetKeyDown(KeyCode.D)){
            Debug.Log("Right");
            animator.SetBool("RightWalk", true);
        } else {
            animator.SetBool("RightWalk", false);
        }
        if(Input.GetKeyDown(KeyCode.W)){
            animator.SetBool("RightJump", true);
        } else {
            animator.SetBool("RightJump", false);
        }
    }
}
