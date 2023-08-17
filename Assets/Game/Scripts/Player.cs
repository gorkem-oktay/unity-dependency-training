using Sirenix.OdinInspector;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health = 100;
    [SerializeField] private int _damage = 10;

    [SerializeField] private ChapterSystem _chapterSystem;

    [Button]
    public void Hit(Enemy enemy)
    {
        IronSource.Agent.showRewardedVideo(
            (placement, info) => { enemy.TakeDamage(_damage * 2); },
            (error, info) => { enemy.TakeDamage(_damage); }
        );
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        IronSource.Agent.showRewardedVideo(
            (placement, info) => { _health = 100; },
            (error, info) => _chapterSystem.Restart()
        );
    }
}