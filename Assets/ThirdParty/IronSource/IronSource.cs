using System;
using Random = UnityEngine.Random;

public class IronSource
{
    private static IronSource _instance;

    public static IronSource Agent
    {
        get
        {
            if (_instance == null)
            {
                _instance = new IronSource();
            }

            return _instance;
        }
    }

    public void showRewardedVideo(
        Action<IronSourcePlacement, IronSourceAdInfo> onSuccess,
        Action<IronSourceError, IronSourceAdInfo> onFail,
        string deviceId)
    {
        if (Random.Range(0, 2) == 0)
        {
            onSuccess?.Invoke(null, null);
        }
        else
        {
            onFail?.Invoke(null, null);
        }
    }

    public void showInterstitial(
        Action<IronSourceAdInfo> onSuccess,
        Action<IronSourceError, IronSourceAdInfo> onFail)
    {
        if (Random.Range(0, 2) == 0)
        {
            onSuccess?.Invoke(null);
        }
        else
        {
            onFail?.Invoke(null, null);
        }
    }

    public bool isRewardedVideoAvailable()
    {
        return true;
    }

    public bool isInterstitialReady()
    {
        return true;
    }
}