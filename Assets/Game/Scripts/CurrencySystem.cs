using Game.Scripts;
using Sirenix.OdinInspector;
using UnityEngine;

public class CurrencySystem
{
    [ShowInInspector] public int Gold { get; private set; }

    private IAdvertisementService _advertisementService;
    //private MissionSystem _missionSystem;

    public CurrencySystem(IAdvertisementService advertisementService /*, MissionSystem missionSystem*/)
    {
        _advertisementService = advertisementService;
        //_missionSystem = missionSystem;
    }

    public void AddGold(int amount)
    {
        _advertisementService.showRewardedVideo(
            () => OnRewardedFinish(amount * 2),
            () => OnRewardedFinish(amount)
        );
    }

    private void OnRewardedFinish(int amount)
    {
        Gold += amount;

        Debug.Log($"Gold added: {amount}");

        //_missionSystem.AddProgress(MissionType.CollectGold, amount);
    }
}