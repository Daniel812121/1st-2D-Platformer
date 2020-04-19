using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
    public Collider2D boxCollider;

    public void OnTriggerEnter2D(Collider2D boxCollider)
    {
        gameManager.CompleteLevel();
    }
}
