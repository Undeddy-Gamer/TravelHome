using UnityEngine;
using System.Collections;

public class Orbit : MonoBehaviour
{
    public Transform target;
          
    public Vector3 axis;//the axis it will rotate (x,y,z)
    public float angle; //angle/speed of rotation.

    
    void Update()
    {
        //Gets the position of the thing to orbit and rotates this gameObject around it
        transform.RotateAround(target.transform.position, axis, angle);
    }
}
