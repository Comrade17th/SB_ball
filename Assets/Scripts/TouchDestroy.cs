using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
        if (other.tag == "Player")
            Destroy(gameObject);
    }
}
