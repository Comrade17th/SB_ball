using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMaker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string nextScene = "level2";

    private void OnTriggerEnter(Collider other)
    {
        
        SceneManager.LoadScene(nextScene);
    }
}
