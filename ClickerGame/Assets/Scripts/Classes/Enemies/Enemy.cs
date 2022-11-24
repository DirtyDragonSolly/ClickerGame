using UnityEngine;

public class Enemy : MonoBehaviour
{
    private uint diedCount = 0;
    private const float HEALTH = 100;
    
    [Header("Characteristics")]
    public float health;
    public float armor;

    [Header("Money Price")]
    [SerializeField] public uint price;
    [SerializeField] public MoneyDisplay moneyDisplay;
    
    private void IsDead(bool healthState)
    {
        if (healthState)
        {
            health = HEALTH + ((float)diedCount * (0.1f * HEALTH));
            moneyDisplay.GetMoney((decimal)price);
            gameObject.SetActive(false);
            diedCount++;
        }       
    }
    public void GetDamage(float damage)
    {
        armor -= (damage - damage * (1 - (armor / 100)))/3;
        health = armor > 0 ? health - damage * (1 - (armor / 100)) : health - damage;
        IsDead(health <= 0);
    }

    private void Update()
    {
        IsDead(health <= 0);
    }    
}
