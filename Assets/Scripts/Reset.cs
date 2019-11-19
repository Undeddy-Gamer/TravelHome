using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Reset functions
    public Rigidbody rigid;

    public void ResetCharacter()
    {
        //check if player is below theshold
        transform.position = new Vector3(7, 0, -8);

        //stop player movement
        rigid.velocity = Vector3.zero;
        //move player to original start position
        rigid.angularVelocity = Vector3.zero;
    }

    public void ResetLevel()
    {
        //reload current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
}
