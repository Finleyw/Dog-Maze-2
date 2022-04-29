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
    
    float timer=0;
    bool timerReached;
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
        print(other.tag);

        if (other.CompareTag("Bullet"))
        {
            alive=false;
            /*bool tempcheck= Timed(5);
            if (tempcheck==true)
            {
                
            }*/

        }
    }
    bool Timed (float secs)
    {
        timerReached=false;
        timer=0;
        if (!timerReached)
        timer += Time.deltaTime;

        if (!timerReached && timer > secs)
        {
            Debug.Log("Done waiting");

            //Set to false so that We don't run this again
            timerReached = true;
            
        }
        return timerReached;
    }
    
}