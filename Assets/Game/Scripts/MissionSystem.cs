using System;
using System.Collections.Generic;
using System.Linq;
using Game.Scripts;
using UnityEngine;

public enum MissionType
{
    Undefined = 0,
    KillEnemy = 1,
    CollectGold = 2
}

[Serializable]
public class Mission
{
    public bool IsFinished => progress >= goal;

    public MissionType type;
    public int goal;
    public int progress;
    public int reward;

    public Mission(MissionType type, int goal, int reward)
    {
        this.type = type;
        this.goal = goal;
        this.progress = 0;
    }
}

public class MissionSystem
{
    private List<Mission> _missions;

    private IAdvertisementService _advertisementService;
    private CurrencySystem _currencySystem;

    public MissionSystem(IAdvertisementService advertisementService, CurrencySystem currencySystem)
    {
        _advertisementService = advertisementService;
        _currencySystem = currencySystem;
    }

    private void Awake()
    {
        _missions = new List<Mission>
        {
            new Mission(MissionType.CollectGold, 100, 10),
            new Mission(MissionType.KillEnemy, 100, 10)
        };
    }

    public void AddProgress(MissionType type, int progress)
    {
        var mission = _missions.FirstOrDefault(x => x.type == type);

        if (mission == null)
        {
            return;
        }

        mission.progress += progress;

        if (mission.IsFinished)
        {
            Debug.Log($"Mission finished: {mission.type}");

            _advertisementService.showRewardedVideo(
                () => _currencySystem.AddGold(mission.reward * 2),
                () => _currencySystem.AddGold(mission.reward)
            );
        }
    }
}