using System;

public class MaxSdkCallbacks
{
    public class Rewarded
    {
        public static Action<string, MaxSdkBase.AdInfo> OnAdDisplayedEvent;
        public static Action<string, MaxSdkBase.ErrorInfo, MaxSdkBase.AdInfo> OnAdDisplayFailedEvent;
    }

    public class Interstitial
    {
        public static Action<string, MaxSdkBase.AdInfo> OnAdDisplayedEvent;
        public static Action<string, MaxSdkBase.ErrorInfo, MaxSdkBase.AdInfo> OnAdDisplayFailedEvent;
    }
}