using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float turnSpeed = 1000f;
    private float horizontalInput, verticalInput;

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

        //Get speed
        if (verticalInput>=0) {
            speed = 20f; //FRONTSPEED
        } else {
            speed = 5f; //BACKSPEED
        }


        //Update Movement
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        //transform.Translate(Vector3.right * (speed/2) * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.up * (turnSpeed*speed)/5 * Time.deltaTime * horizontalInput);

        if (Input.GetKey(KeyCode.R)) {
            initiateChar();
        }

    }

    //Initiate character
    private void initiateChar() {
        transform.SetPositionAndRotation(Vector3.zero,Quaternion.Euler(0,0,0));
    }
}
