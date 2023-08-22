using System;

namespace Game.Scripts
{
    public class NullAdvertisementService : IAdvertisementService
    {
        public void showRewardedVideo(Action onSuccess, Action onFail)
        {
            onSuccess?.Invoke();
        }

        public void showInterstitial(Action onSuccess, Action onFail)
        {
            onSuccess?.Invoke();
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