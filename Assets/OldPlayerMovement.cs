using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.1f;
    float i = 0;
    public float gravitySpeed = 0.03f;
    CharacterController controller;
    
    
        // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, -gravitySpeed, 0);

        if (Input.GetKey(KeyCode.A))
        {
            direction.x -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction.x += speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            direction.z += speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction.z -= speed;
        }

        controller.Move(direction);

    }
}
