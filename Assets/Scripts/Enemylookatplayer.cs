using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemylookatplayer : MonoBehaviour
{
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            transform.LookAt(target);
        }
    }
}
