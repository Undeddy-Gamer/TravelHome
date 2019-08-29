using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public Rigidbody rigid;

    public void ResetCharacter()
    {
        transform.position = new Vector3(7, 0, -8);
        rigid.velocity = Vector3.zero;
        rigid.angularVelocity = Vector3.zero;
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void HomeSweetHome()
    {
        /*
        if (isBadBox)
        {

        }
        else if (isCheater) 
        {

        }
        else if (hasKey && isHome)
        {
            //YOU WIN

        }
        else  //Forgot Key
        {

        }*/
    }
}
