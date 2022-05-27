using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading;
using UnityEngine;

public class randomToggle : MonoBehaviour
{
    public ParticleSystem particle;
    public bool hasFire;
    static System.Random rand = new System.Random();
    public int id;
    public GameObject scoreObject;

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    { 
        hasFire = rand.NextDouble() >= 0.5f;
        if(id == 2)
        {
            hasFire = false;
        }
        particle.enableEmission = hasFire;
        scoreObject.GetComponent<score>().setAnsArray(id, hasFire);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
