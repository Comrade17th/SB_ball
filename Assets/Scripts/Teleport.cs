using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform positionToTeleport;
    

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Vector3 newPosition = positionToTeleport.position;
        newPosition.y += other.transform.localScale.y;
        
        other.gameObject.transform.position = newPosition;
    }

}
