using System;

namespace Game.Scripts
{
    public interface IAdvertisementService : IService
    {
        void showRewardedVideo(Action onSuccess, Action onFail);
        void showInterstitial(Action onSuccess, Action onFail);

        bool isRewardedVideoAvailable();
        bool isInterstitialReady();
    }
}