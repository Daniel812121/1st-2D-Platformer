using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// Attach to an empty GameObject
// To initialize script on a new scene, add updateHealthUI() in the Awake or Start Method of your player
// Then just use this script in your OnCollision method using thisScript.Health --
public class PlayerHealth : MonoBehaviour // MonoBehaviour
{

    // Insert your 3 hearts images in the Unity Editor
    public Image h1, h2, h3;
    // Create an array because we're lazy
    public Image[] images;
    // Gameover
    [SerializeField] private Image gameOver;
    // A private variable to keep between scenes
    public int health = 3;
    // Now we define Get / Set methods for health
    // In case we Set health to a different value we want to update UI
    public int Health { get { return health; } set { if (health != Health) health = Health; updateHealthUI(); } }

    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        images = new Image[] { h1, h2, h3 };
    }
    private void updateHealthUI()
    {
        for (int i = 0; i < images.Length; i++)
        {
            // Hide all images superior to the newHealth
            if (i >= health)
                images[i].enabled = false;
            else
                images[i].enabled = true;
        }
        // Game Over
        if (health == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
    void Update()
    {
        if (transform.position.y == -20)
        {
            health--;
        }
        if (health == 3)
        {
            images = new Image[] { h1, h2, h3 };
        }
        else if (health == 2)
        {
            images = new Image[] { h1, h2 };
        }
        else if (health == 1)
        {
            images = new Image[] { h1 };
        }
  
      
    }
}