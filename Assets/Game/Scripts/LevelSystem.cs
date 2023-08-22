using Game.Scripts;
using Sirenix.OdinInspector;
using UnityEngine;

public class LevelSystem
{
    private int _goal = 100;

    [ShowInInspector] private int _level = 1;
    [ShowInInspector] private int _experience;

    private IAdvertisementService _advertisementService;

    public LevelSystem(IAdvertisementService advertisementService)
    {
        _advertisementService = advertisementService;
    }

    public void AddExperience(int amount)
    {
        _advertisementService.showRewardedVideo(
            () => OnRewardedFinish(amount * 2),
            () => OnRewardedFinish(amount)
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