using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnTouch : MonoBehaviour
{
    public float DestroyDelayTime;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            DestroyObecjtDelayed();
    }

    void DestroyObecjtDelayed()
    {
        Destroy(gameObject, DestroyDelayTime);
    }
}
