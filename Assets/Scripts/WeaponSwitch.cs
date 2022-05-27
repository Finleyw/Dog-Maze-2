using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WeaponSwitch : MonoBehaviour
{
    public GameObject pistol;
    public GameObject gun;
    public GameObject bat;
    // Start is called before the first frame update
    void Start()
    {
        pistol.SetActive(true);
        gun.SetActive(false);
        bat.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("1"))
        {
            pistol.SetActive(true);
            gun.SetActive(false);
            bat.SetActive(false);
        }
        if(Input.GetKey("2"))
        {
            print("yeh");
            pistol.SetActive(false);
            gun.SetActive(true);
            bat.SetActive(false);
        }
        if(Input.GetKey("3"))
        {
            pistol.SetActive(false);
            gun.SetActive(false);
            bat.SetActive(true);
        }
    }
}
