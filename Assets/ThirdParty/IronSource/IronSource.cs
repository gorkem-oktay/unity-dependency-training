using System;

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

    //******************* RewardedVideo API *******************//
    public void loadRewardedVideo()
    {
    }

    public void showRewardedVideo(
        Action<IronSourcePlacement, IronSourceAdInfo> onSuccess,
        Action<IronSourceError, IronSourceAdInfo> onFail)
    {
    }

    public bool isRewardedVideoAvailable()
    {
        return true;
    }

    //******************* Interstitial API *******************//
    public void loadInterstitial()
    {
    }

    public void showInterstitial(
        Action<IronSourceAdInfo> onSuccess,
        Action<IronSourceError, IronSourceAdInfo> onFail)
    {
    }

    public bool isInterstitialReady()
    {
        return true;
    }
}