using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMove : MonoBehaviour
{
    static bool direction = true;
    public CharacterController controller;
    float ogSpeed;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        ogSpeed = 3 + Random.value * 3;

        speed = ogSpeed;
        if (direction)
        {
            speed *= -1;
        }

        direction = !direction;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -14f)
        {
            speed = ogSpeed;
        }
        else if (transform.position.x >= 14f)
        {
            speed = -ogSpeed;
        }

        controller.Move(new Vector3(speed * Time.deltaTime, 0f, 0f));
        transform.position.Set(transform.position.x, 0, transform.position.z);
    }
}
