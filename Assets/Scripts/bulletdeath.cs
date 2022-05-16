using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Destroy(gameObject,3.5f); 
    }

    void OnCollisionEnter(Collision hitinfo)
    {
        Destroy(gameObject);
    }
    
}
