using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class winCondition : MonoBehaviour
{
    public GameObject winText;
    public int points;
    public int pointGoal=8;
    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        points=0;
    }

    // Update is called once per frame
    void Update()
    {
        print(points);
        if(points==pointGoal)
        {
            winText.SetActive(true);

        }
    }
}
