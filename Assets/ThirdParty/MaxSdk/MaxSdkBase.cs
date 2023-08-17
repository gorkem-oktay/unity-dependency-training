public class MaxSdkBase
{
    public enum ErrorCode
    {
        Unspecified = -1,
        NoFill = 204,
        AdLoadFailed = -5001,
        AdDisplayFailed = -4205,
        NetworkError = -1000,
        NetworkTimeout = -1001,
        NoNetwork = -1009,
        FullscreenAdAlreadyShowing = -23,
        FullscreenAdNotReady = -24,
        NoActivity = -5601,
        DontKeepActivitiesEnabled = -5602,
    }

    public class ErrorInfo
    {
        public ErrorCode Code { get; private set; }
        public string Message { get; private set; }
        public int MediatedNetworkErrorCode { get; private set; }
        public string MediatedNetworkErrorMessage { get; private set; }
        public string AdLoadFailureInfo { get; private set; }
    }

    public class AdInfo
    {
        public string AdUnitIdentifier { get; private set; }
        public string AdFormat { get; private set; }
        public string NetworkName { get; private set; }
        public string NetworkPlacement { get; private set; }
        public string Placement { get; private set; }
        public string CreativeIdentifier { get; private set; }
        public double Revenue { get; private set; }
        public string RevenuePrecision { get; private set; }
        public string DspName { get; private set; }
    }
}