using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_CheckPoint : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isVisited;

    private void Start()
    {
        isVisited = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && isVisited == false)
        {
            isVisited = true;
            other.GetComponent<CheckPoinSystem>().Lifes = other.GetComponent<CheckPoinSystem>().MaximumLifes;
            other.GetComponent<CheckPoinSystem>().currentCheckPoint = transform.position;
        }
        
    }
}
