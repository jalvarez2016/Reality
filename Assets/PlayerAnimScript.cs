using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimScript : MonoBehaviour
{
    public Animator animator;
    public Vector3 LeftMovement;
    public Vector3 RightMovement;
    public Vector3 JumpForce;
    public Rigidbody2D playerRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        // transform.position = new Vector3(0.0f, -2.0f, 0.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetAxisRaw("Horizontal") == -1){
            animator.SetBool("LeftWalk", true);
            animator.SetBool("Right", false);
            animator.SetBool("Left", true);
            playerRigidBody.AddForce(LeftMovement); 
        } else {
            animator.SetBool("LeftWalk", false);
        }
        if(Input.GetAxisRaw("Horizontal") == 1){
            // Debug.Log("Right");
            animator.SetBool("RightWalk", true);
            animator.SetBool("Left", false);
            animator.SetBool("Right", true);
            GetComponent<Rigidbody2D>().AddForce(RightMovement); 
        } else {
            animator.SetBool("RightWalk", false);
        }
        if(Input.GetKeyDown(KeyCode.W)){
            if(animator.GetBool("Right")){
               animator.SetBool("RightJump", true);
            } else {
                animator.SetBool("LeftJump", true);
            }
            // GetComponent<Rigidbody2D>().AddForce(transform.up * thrust);
            GetComponent<Rigidbody2D>().AddForce(JumpForce); 
        } else {
            if(animator.GetBool("Right")){
                animator.SetBool("RightJump", false);
            } else {
                animator.SetBool("LeftJump", false);
            }
        }
    }
}
