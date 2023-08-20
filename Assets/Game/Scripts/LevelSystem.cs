using Sirenix.OdinInspector;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    private int _goal = 100;

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

        Debug.Log($"Experience added: {amount}");

        if (_experience >= _goal)
        {
            _level++;
            _experience = 0;
        }
    }
}