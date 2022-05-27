using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementNew : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 13f;
    public float gravity = -0.5f;
    public GameObject freezeObject;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z + transform.up * gravity;

        controller.Move(move * speed * Time.deltaTime);

        if (transform.position.y <= -1.22f)
        {
            freezeObject.GetComponent<freezeBar>().die();
        }
    }
}
