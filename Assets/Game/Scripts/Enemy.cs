using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

public class Enemy : MonoBehaviour
{
    [Inject] private MissionSystem _missionSystem;
    [Inject] private CurrencySystem _currencySystem;
    [Inject] private LevelSystem _levelSystem;

    [SerializeField] private int _health = 100;

    [Button]
    public void Hit(Player player)
    {
        Debug.Log($"Hit: {name} -> Player");

        player.TakeDamage(10);
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;

        Debug.Log($"Took damage: {damage}({name})");

        if (_health < 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log($"{name} died");

        gameObject.SetActive(false);
        _missionSystem.AddProgress(MissionType.KillEnemy, 1);
        _currencySystem.AddGold(10);
        _levelSystem.AddExperience(10);
    }

    public class FactoryInterface : PlaceholderFactory<Object, Enemy>
    {
    }

    public class FactoryImplementation : IFactory<Object, Enemy>
    {
        private DiContainer _diContainer;

        public FactoryImplementation(DiContainer diContainer)
        {
            _diContainer = diContainer;
        }

        public Enemy Create(Object param)
        {
            var enemy = _diContainer.InstantiatePrefabForComponent<Enemy>(param);
            return enemy;
        }
    }
}