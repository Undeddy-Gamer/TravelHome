using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour    
{
    /*
     * 
     * 
     * 
     */

    //<access-specifier> <data-type> <variable name>
    public Rigidbody rigid;
    public static float speed = 5F;
    public static bool hasKey = false;
    public static bool isBadBox = false;
    public static bool cheater = false;

    // Update is called once per frame
    void Update()
    {
        // Get input axis from user
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(inputH, 0, inputV);

        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rigid.AddForce(direction * (speed * 1.5f)); 
        }
        else
        {
            rigid.AddForce(direction * speed);
        }


        //

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

    }


    void Jump()
    {
        Vector3 upit = new Vector3(0, 60, 0);
        rigid.AddForce(upit);
        cheater = true;
    }

    public void GetKey()
    {
        hasKey = true;
    }


    
}
