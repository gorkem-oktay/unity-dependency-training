using Sirenix.OdinInspector;
using UnityEngine;

public class CurrencySystem : MonoBehaviour
{
    [SerializeField] private MissionSystem _missionSystem;

    [ShowInInspector] public int Gold { get; private set; }

    public void AddGold(int amount)
    {
        IronSource.Agent.showRewardedVideo(
            (placement, info) => OnRewardedFinish(amount * 2),
            (error, info) => OnRewardedFinish(amount)
        );
    }

    private void OnRewardedFinish(int amount)
    {
        Gold += amount;

        Debug.Log($"Gold added: {amount}");

        _missionSystem.AddProgress(MissionType.CollectGold, amount);
    }
}