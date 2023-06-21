using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoinSystem : MonoBehaviour
{
    private Vector3 startCheckpoint;

    [SerializeField] public Vector3 currentCheckPoint;
    
    public float deathY = -3f;
    public int Lifes = 3;
    public int MaximumLifes = 3;
    //public int currentCheckpoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        startCheckpoint = transform.position;
        currentCheckPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < deathY)
        {
            Lifes--;
            if (Lifes == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Lifes = MaximumLifes;
                currentCheckPoint = startCheckpoint;
            }
                            
            transform.position = currentCheckPoint;
        }
    }
}
