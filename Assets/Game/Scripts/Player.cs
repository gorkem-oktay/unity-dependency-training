using Game.Scripts;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

public class Player : MonoBehaviour
{
    [Inject] private ChapterSystem _chapterSystem;
    [Inject] private IAdvertisementService _advertisementService;
    [Inject] private Enemy.FactoryInterface _enemyFactory;

    [SerializeField] private int _health = 100;
    [SerializeField] private int _damage = 10;
    [SerializeField] private Enemy _enemy;

    private void Awake()
    {
        _enemyFactory.Create(_enemy);
    }

    [Button]
    public void Hit(Enemy enemy)
    {
        Debug.Log($"Hit: Player -> {enemy.name}");

        _advertisementService.showRewardedVideo(
            () => enemy.TakeDamage(_damage * 2),
            () => enemy.TakeDamage(_damage)
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
        _advertisementService.showRewardedVideo(
            () =>
            {
                _health = 100;
                Debug.Log("Player resurrected");
            },
            () => _chapterSystem.Restart()
        );
    }
}