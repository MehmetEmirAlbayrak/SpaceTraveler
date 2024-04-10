using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hpbar : MonoBehaviour
{
    public Ship character; // Reference to the character's Ship component
    public Scrollbar healthBar; // Reference to the health scrollbar

    void Update()
    {
        // Ensure that character and healthBar references are set
        if (character == null || healthBar == null)
        {
            Debug.LogWarning("Character or healthBar references are not set!");
            return;
        }

        // Calculate the normalized health value
        float normalizedHealth = character.GetHp() / 100.0f;

        // Update the scrollbar value with the normalized health
        healthBar.size = normalizedHealth;
    }
}

