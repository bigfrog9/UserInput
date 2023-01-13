using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool spinning = false;
    
    // Update is called once per frame
    void Update()
    {

        float turnSpeed = 40.0f;

        if (spinning == false && Input.GetKeyDown(KeyCode.Space))
        {
            spinning = true;

        }

        if (spinning == true)
        {
            gameObject.transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            spinning = false;
        }


        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);

        }
    }
}
