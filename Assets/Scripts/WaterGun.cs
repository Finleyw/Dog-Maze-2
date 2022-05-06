using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterGun : MonoBehaviour
{
    public int ammo;
    private Animator anim;
    public Rigidbody projectile;
    public Transform barrelend;
    public float firespeed;
    public Text ammoCount;
    //int delay = 0;

    void Start()
    {
        anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("Shooting",true);
        }
        if(Input.GetButtonUp("Fire1"))
        {
            anim.SetBool("Shooting",false);
        }
        /*if (delay>0)
        {
            delay--;
        }
        if(Input.GetButtonDown("Fire1"))
        {
            
            
            fire();
            
            
            
        } 
        if (delay==0)
        {
            anim.SetBool("Fire",false);
        } */

        ammoCount.text=ammo.ToString();
    }
    void Shooting()
    {
        if (ammo>0)
        {
            Rigidbody projectileInstance;
            projectileInstance= Instantiate(projectile, barrelend.position,barrelend.rotation) as Rigidbody;
            projectileInstance.AddForce(barrelend.forward*firespeed);
            ammo--;
        }
    }

    
      
}
