using System;

namespace Game.Scripts
{
    public class IronSourceAdvertisementService : IAdvertisementService
    {
        public static IronSourceAdvertisementService Instance;

        public void showRewardedVideo(
            Action onSuccess,
            Action onFail)
        {
            if (IronSource.Agent.isRewardedVideoAvailable())
            {
                IronSource.Agent.showRewardedVideo(
                    (placement, info) => { onSuccess?.Invoke(); },
                    (error, info) => { onFail?.Invoke(); },
                    "qweqwe");
            }
        }

        public void showInterstitial(
            Action onSuccess,
            Action onFail)
        {
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
}