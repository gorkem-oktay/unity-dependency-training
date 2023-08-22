using System;

namespace Game.Scripts
{
    public class AppLovinAdvertisementService : IAdvertisementService
    {
        public static AppLovinAdvertisementService Instance;

        public void showRewardedVideo(
            Action onSuccess,
            Action onFail)
        {
            MaxSdkCallbacks.Rewarded.OnAdDisplayedEvent = ((s, info) => onSuccess?.Invoke());
            MaxSdkCallbacks.Rewarded.OnAdDisplayFailedEvent = (s, info, arg3) => { onFail?.Invoke(); };

            MaxSdk.ShowRewardedAd("");
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