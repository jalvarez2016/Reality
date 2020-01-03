using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Update is called once per frame
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate() 
    {
        transform.position = player.transform.position + offset;
    }


}
