using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public event Action OnDeath = delegate {}; 

    [SerializeField]
    private int maxHealth = 3;
    public int currentHealth { get; private set; }

    private void Awake() {
        currentHealth = maxHealth;
    }

    public void SetHealth(int value) {
        currentHealth -= value;

        if (currentHealth <= 0) {
            OnDeath();
        }
    }
}
