using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100; // The maximum health of the object
    private int currentHealth; // The current health of the object

    private void Start()
    {
        currentHealth = maxHealth; // Set the initial health to the maximum health
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // Reduce the current health by the damage amount

        if (currentHealth <= 0)
        {
            Die(); // Call the Die method when health reaches or falls below zero
        }
    }

    private void Die()
    {
        // Implement your logic for when the object dies (e.g., play an animation, spawn particles, etc.)
        Destroy(gameObject); // Destroy the object
    }
}