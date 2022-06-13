using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMouvement : MonoBehaviour
{
    public float Speed = -3;
 
 
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward  * Time.fixedDeltaTime * Speed);
    }
     
}
