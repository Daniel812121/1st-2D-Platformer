using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnd : MonoBehaviour
{
    public GameObject victoryScreen;
    public Collider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        victoryScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        { 
            if(Input.GetKey(KeyCode.N))
            {
                victoryScreen.SetActive(true);
            }
        }
    }
}
