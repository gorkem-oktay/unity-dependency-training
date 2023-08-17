using Sirenix.OdinInspector;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private MissionSystem _missionSystem;
    [SerializeField] private CurrencySystem _currencySystem;
    [SerializeField] private LevelSystem _levelSystem;

    [SerializeField] private int _health = 100;

    [Button]
    public void Hit(Player player)
    {
        player.TakeDamage(10);
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health < 0)
        {
            Die();
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
        _missionSystem.AddProgress(MissionType.KillEnemy, 1);
        _currencySystem.AddGold(10);
        _levelSystem.AddExperience(10);
    }
}