using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle : MonoBehaviour
{
    public ParticleSystem particles;
    public GameObject player;

    public bool isBurning = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Vector3.Distance(this.transform.position, player.transform.position) < 5)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                isBurning = false;
                particles.enableEmission = false;
            }
        }
    }
}
