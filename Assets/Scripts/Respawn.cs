using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
   
    //The threshold height for resporning when falling
    public float threshold;

    void FixedUpdate()
    {
        //check if falling below threshold and move player back to start position (hard coded position)
        if (transform.position.y < threshold)
            transform.position = new Vector3(7, 0, -8);
       
    }

    void ResetLevel()
    {
        // not used
    }


}

