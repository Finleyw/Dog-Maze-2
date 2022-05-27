using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
  private Animator anim;
  public Rigidbody projectile;
  public Transform barrelend;
  public float firespeed;
  public int shots=7;
  int setShots;
  public Text ammoCount;

  int delay = 0;

  void Start()
  {
    setShots=shots;
    anim= GetComponent<Animator>();
  }

    // Update is called once per frame
  void Update()
  {
    ammoCount.text=shots.ToString();

    
    if (delay>0)
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
    } 
    
    if(Input.GetKey("r"))
    {
      anim.SetTrigger("Reload");
    }  
        

  }
  void fire()
  {
    if(shots>0)
    {
      if(delay==0)
      {
        Rigidbody projectileInstance;
        projectileInstance= Instantiate(projectile, barrelend.position,barrelend.rotation) as Rigidbody;
        projectileInstance.AddForce(barrelend.forward*firespeed);
        anim.SetBool("Fire",true);
        shots--;
        delay=21;
      }
    }
  }
  void reload()
  {
    print("reloaded");
    shots=setShots;
  }

}
