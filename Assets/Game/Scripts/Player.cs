using Sirenix.OdinInspector;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private ChapterSystem _chapterSystem;

    [SerializeField] private int _health = 100;
    [SerializeField] private int _damage = 10;

    [Button]
    public void Hit(Enemy enemy)
    {
        Debug.Log($"Hit: Player -> {enemy.name}");

        IronSource.Agent.showRewardedVideo(
            (placement, info) => enemy.TakeDamage(_damage * 2),
            (error, info) => enemy.TakeDamage(_damage)
        );
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;

        Debug.Log($"Took damage: {damage}(Player)");

        if (_health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        IronSource.Agent.showRewardedVideo(
            (placement, info) =>
            {
                _health = 100;
                Debug.Log("Player resurrected");
            },
            (error, info) => _chapterSystem.Restart()
        );
    }
}