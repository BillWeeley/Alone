using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform ItemSpawn;
    public GameObject Tree;
    public int maxHealth = 100;
    int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            DropItems();
            Die();
        }
    }

    void Die()
    {
        Destroy(ItemSpawn.gameObject);  
        
    }

    private void Instantiate(GameObject item, Vector3 position)
    {
        throw new NotImplementedException();
    }

    void DropItems()
    {
        Transform objectToDrop;
        if (ItemSpawn.gameObject.CompareTag ("Trees"))
        {
            Instantiate(Tree, ItemSpawn);
        }
    }
}
