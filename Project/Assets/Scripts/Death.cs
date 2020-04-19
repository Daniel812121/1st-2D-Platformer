using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Death")
        {
            SceneManager.LoadScene(2);
        }
    }
}
