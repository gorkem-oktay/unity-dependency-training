using UnityEngine;

public class MaxSdk
{
    public static void LoadInterstitial(string adUnitId)
    {
    }

    public static bool IsInterstitialReady(string adUnitId)
    {
        return true;
    }

    public static void ShowInterstitial(string adUnitId)
    {
        if (Random.Range(0, 2) == 0)
        {
            MaxSdkCallbacks.Interstitial.OnAdDisplayedEvent?.Invoke("", null);
        }
        else
        {
            MaxSdkCallbacks.Interstitial.OnAdDisplayFailedEvent?.Invoke("", null, null);
        }
    }

    public static void LoadRewardedAd(string adUnitId)
    {
    }

    public static bool IsRewardedAdReady(string adUnitId)
    {
        return true;
    }

    public static void ShowRewardedAd(string adUnitId)
    {
        if (Random.Range(0, 2) == 0)
        {
            MaxSdkCallbacks.Rewarded.OnAdDisplayedEvent?.Invoke("", null);
        }
        else
        {
            MaxSdkCallbacks.Rewarded.OnAdDisplayFailedEvent?.Invoke("", null, null);
        }
    }
}