using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public LayerMask enemyLayers;
    //alt and arrow keys flips line
    public float attackRange = 0.5f;
    public int attackDamage = 40;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Attack();
        }
    }
    
    void Attack()
    {
        //Attack Animation
        animator.SetTrigger("Attack");
        //Detection
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        //Damage
        foreach(Collider2D enemy in hitEnemies)
        {
            //enemy.GetComponent<Enemy>().TakeDamage();
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return; 

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}

//https://www.youtube.com/watch?v=sPiVz1k-fEs Brackey's tutorials

