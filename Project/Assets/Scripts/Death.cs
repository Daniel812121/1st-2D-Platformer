using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        //health--;
        void Update()
        {
            if (transform.position.y == -20)
            {
                health--;
            }
            if (health == 3)
            {

            }
            else if (health == 2)
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
}
