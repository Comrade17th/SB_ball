using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift_2_0 : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float forceUp;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            rb = other.GetComponent<Rigidbody>();
            //rb.velocity = new Vector3(0, rb.velocity.y, 0);
            rb.AddForce(Vector3.up * forceUp * Time.deltaTime);
            //time = 2.0f;
            //isTimerOn = true;
            Debug.Log("inside");
        }
    }
}
