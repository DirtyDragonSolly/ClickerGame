using System;
using UnityEngine;
using UnityEngine.UI;

public class SuperHeroEnemy : Enemy
{
    [Header ("UI Elements")]
    [SerializeField] Text healthText;

    private void Update()
    {
        healthText.text = $"Health: {Math.Round(health)}";
    }
}
