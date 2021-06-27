using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

     Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveHorizontal, 0.0f, moveVertical);
        

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(0.0f , 200f , 0.0f);
        }
        rb.AddForce(move * 100);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("pickups"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
