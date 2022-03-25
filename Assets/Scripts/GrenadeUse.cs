using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeUse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*ParticleSystem ps = GetComponent<ParticleSystem>();
        var main = ps.main;
        main.startDelay = 3.0f;
        main.startLifetime = 1.0f;*/

        StartCoroutine(Run());
        //var em = ps.emission;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Run()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
    
}
