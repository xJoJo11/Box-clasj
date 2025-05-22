using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
public int health = 100;


public void TakeDamage(int amount)
{
    health -= amount;
    Debug.Log("Player took damage! Health: " + health);

    if (health <= 0)
    {
        Debug.Log("Player died.");
        // Optional: handle death (restart, game over, etc.)
    }
}
}