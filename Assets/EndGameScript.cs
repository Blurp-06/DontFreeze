using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour
{
    public ParticleSystem particle;
    public GameObject player;
    bool canEnd = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float dx = player.transform.position.x - this.transform.position.x;
        float dz = player.transform.position.z - this.transform.position.z;

        if (canEnd && (dx * dx + dz * dz) <= 9.0f) {
            SceneManager.LoadScene("congrats", LoadSceneMode.Single);
        }
    }

    [System.Obsolete]
    public void enableEnd()
    {
        particle.enableEmission = true;
        canEnd = true;
    }
}
