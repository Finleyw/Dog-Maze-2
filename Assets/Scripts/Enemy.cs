using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool alive=true;
    
    
    
    public Transform Player;
    public int MoveSpeed = 4;
    public int MaxDist = 10;
    public int MinDist = 5;
    
    private Animator anim;
 
 

    void Start()
    {
        anim= GetComponent<Animator>();

    }

    void Update()
    {
        if (alive==true)
        {
            transform.LookAt(Player);

            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {

                transform.position += transform.forward * MoveSpeed * Time.deltaTime;



                if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
                {
                    //Here Call any function U want Like Shoot at here or something
                }

            }
        }
        if (alive== false)
        {
            anim.SetTrigger("Dead");
            Destroy(gameObject,5f);
        }
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Bullet"))
        {
            alive=false;
        }
    }
    
    
}