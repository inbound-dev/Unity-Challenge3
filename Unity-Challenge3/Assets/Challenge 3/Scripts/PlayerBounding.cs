using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounding : MonoBehaviour
{
    private float playerPos; 

    void Update()
    {
        playerPos = transform.position.y;
        
        if(playerPos >= 16){
            playerPos = 16;
        }
        else if(playerPos <= 0){
            playerPos = 0;
        }
    }
}
