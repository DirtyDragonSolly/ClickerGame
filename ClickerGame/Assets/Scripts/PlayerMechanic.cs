using UnityEngine;

public class PlayerMechanic : MonoBehaviour
{
    public int damageLevel;
    public int damage = 1;

    public void ClickOnEnemy(Enemy enemy)
    {
        GiveDamage(enemy);
    }

    public void GiveDamage(Enemy enemy)
    {
        enemy.GetDamage(damage);
    }
}
