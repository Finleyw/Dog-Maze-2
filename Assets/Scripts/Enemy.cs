using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool alive=true;
    
    public float targetTime ;
    float timer;
    public Transform shootPoint;
    public Transform Player;
    public int MoveSpeed = 4;
    
    
    private Animator anim;
 
    public Rigidbody projectile;
    public Transform barrelend;
    public float firespeed;
    //int delay = 0;
    bool canShoot;

    void Start()
    {
        anim= GetComponent<Animator>();
        timer=targetTime;
    }

    void Update()
    {
        print(canShoot);
        targetTime -= Time.deltaTime;
        if(targetTime<=0)
        {
            canShoot=true;
        }
        else
        {
            canShoot=false;
        }

        if (alive==true)
        {
            transform.LookAt(Player);

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            Shoot();
           
        }
        if (alive== false)
        {
            anim.SetTrigger("Dead");
            Destroy(gameObject,5f);
        }
    }

    void Shoot()
    {
    
        if(canShoot==true)
        {
            
            Rigidbody projectileInstance;
            projectileInstance= Instantiate(projectile, barrelend.position,barrelend.rotation) as Rigidbody;
            projectileInstance.AddForce(barrelend.forward*firespeed);
            targetTime=timer;
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