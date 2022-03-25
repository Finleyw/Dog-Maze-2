using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrow : MonoBehaviour
{
  //private Animator anim;
  public Rigidbody projectile;
  public Transform throwPoint;
  public float firespeed;
  int delay = 0;

  void Start()
  {
    //anim= GetComponent<Animator>();
  }

    // Update is called once per frame
  void Update()
  {
    
      if (delay>0)
      {
        delay--;
      }
      if(Input.GetKeyDown("g"))
      {
        
        
        fire();
        
        
        
      } 
      /*if (delay==0)
      {
        anim.SetBool("Fire",false);
      } */
    
      
        

  }
  void fire()
  {
    if(delay==0)
    {
      Rigidbody projectileInstance;
      projectileInstance= Instantiate(projectile, throwPoint.position,throwPoint.rotation) as Rigidbody;
      projectileInstance.AddForce(throwPoint.forward*firespeed);
      //anim.SetBool("Fire",true);
      delay=21;
    }
  }

}
