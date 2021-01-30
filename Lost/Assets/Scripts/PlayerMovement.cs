using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(0f, 0f, -z);
        controller.Move(move * speed * Time.deltaTime);
    }
}
