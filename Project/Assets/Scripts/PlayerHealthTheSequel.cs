using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthTheSequel : MonoBehaviour
{
    GameObject heart3;
    GameObject heart2;

    int health = 3;
    void Start()
    {
        heart3.SetActive(true);
        heart2.SetActive(true);
    }
    void Update()
    {
        SubtractingHealth();
        RemovingHearts();
    }

     
    void SubtractingHealth()
    {
        if (transform.position.y == -20)
        {
            health--;
        }
        
    }
    void RemovingHearts()
    {
        if (health == 2)
        {
            heart3.SetActive(false);
        }
        else if (health == 1)
        {
            heart3.SetActive(false);
            heart2.SetActive(false);
        }
    }
}

