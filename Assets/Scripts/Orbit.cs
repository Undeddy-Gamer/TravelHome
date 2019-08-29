using UnityEngine;
using System.Collections;

public class Orbit : MonoBehaviour
{
    public Transform target;
          
    public Vector3 axis;//by which axis it will rotate. x,y or z.
    
    public float angle; //or the speed of rotation.

    // Update is called once per frame
    void Update()
    {
        //Gets the position of your 'Turret' and rotates this gameObject around it by the 'axis' provided at speed 'angle' in degrees per update 
        transform.RotateAround(target.transform.position, axis, angle);
    }
}
