using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isTimerOn;
    public float liftForce;
    public float time;
    Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            rb = other.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, 0, 0);
            time = 2.0f;
            isTimerOn = true;
            Debug.Log("touched");
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimerOn)
        {
            
            rb.AddForce(Vector3.up * liftForce * Time.deltaTime);
            time -= Time.deltaTime;
            if (time <= 0.0f)
            {
                isTimerOn=false;

            }
        }
            
        
    }
}
