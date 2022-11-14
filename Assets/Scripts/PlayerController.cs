using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float backSpeed = 5f;
    public float turnSpeed = 8f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Get Horizontal Input movement
        horizontalInput = Input.GetAxis("Horizontal");
        //Get Vertical Input movemnt
        verticalInput = Input.GetAxis("Vertical");
        
        //Movement
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);

        if (Input.GetKey(KeyCode.R)) {
            transform.position = Vector3.zero;
        }

    }
}
