using Sirenix.OdinInspector;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    [SerializeField] private int _goal;

    [ShowInInspector] private int _level = 1;
    [ShowInInspector] private int _experience;

    public void AddExperience(int amount)
    {
        IronSource.Agent.showRewardedVideo(
            (placement, info) => OnRewardedFinish(amount * 2),
            (error, info) => OnRewardedFinish(amount)
        );
    }

    private void OnRewardedFinish(int amount)
    {
        _experience += amount;

        if (_experience >= _goal)
        {
            _level++;
            _experience = 0;
        }
    }
}