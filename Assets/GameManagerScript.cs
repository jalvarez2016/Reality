using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public Vector3 LeftMovement;   
    public Vector3 RightMovement;
    public Vector3 UpMovement;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }

    public void playerMovement()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            player.GetComponent<Transform>().position += LeftMovement;
        }
        if(Input.GetKeyDown(KeyCode.D)){
            player.GetComponent<Transform>().position += RightMovement;
        }
        if(Input.GetKeyDown(KeyCode.W)){
            player.GetComponent<Transform>().position += UpMovement;
        }
        
    }
}
