using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    private Animator anim;
  
  //int delay = 0;

  void Start()
  {
    anim= GetComponent<Animator>();
  }

    // Update is called once per frame
  void Update()
  {
    
     /* if (delay>0)
      {
        delay--;
      }*/
      if(Input.GetButtonDown("Fire1"))
      {
        
        anim.SetBool("Fire",true);
        //fire();
        
        
        
      } 
      else
      {
        anim.SetBool("Fire",false);
      } 
    
      
        

  }
  /*void fire()
  {
    if(delay==0)
    {
      
      
      delay=21;
    }
  }*/
}
