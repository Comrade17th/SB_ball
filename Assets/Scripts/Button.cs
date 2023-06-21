using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Material activeMaterial;
    Material disabledMaterial;
    //MeshRenderer meshRenderer;
    public GameObject linkedObject;
    public bool isOn;
    // Start is called before the first frame update

    private void Start()
    {
        activeMaterial = Resources.Load<Material>("ActiveButton");
        disabledMaterial = Resources.Load<Material>("DisabledButton");
        activeMaterial = gameObject.GetComponent<MeshRenderer>().material;
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Enter");
        if(other.tag == "Player")
            if (isOn)
            {
                isOn = false;
                linkedObject.SetActive(false);
                gameObject.GetComponent<MeshRenderer>().material = disabledMaterial;
            }
            else
            {
                isOn=true;
                linkedObject.SetActive(true);
                gameObject.GetComponent<MeshRenderer>().material = activeMaterial;
            }
    }
}
