public class IronSourceAdInfo
{
    public readonly string auctionId;
    public readonly string adUnit;
    public readonly string country;
    public readonly string ab;
    public readonly string segmentName;
    public readonly string adNetwork;
    public readonly string instanceName;
    public readonly string instanceId;
    public readonly double? revenue;
    public readonly string precision;
    public readonly double? lifetimeRevenue;
    public readonly string encryptedCPM;

    public IronSourceAdInfo(string json)
    {
    }

    public override string ToString()
    {
        return "IronSourceAdInfo {" +
               "auctionId='" + auctionId + '\'' +
               ", adUnit='" + adUnit + '\'' +
               ", country='" + country + '\'' +
               ", ab='" + ab + '\'' +
               ", segmentName='" + segmentName + '\'' +
               ", adNetwork='" + adNetwork + '\'' +
               ", instanceName='" + instanceName + '\'' +
               ", instanceId='" + instanceId + '\'' +
               ", revenue=" + revenue +
               ", precision='" + precision + '\'' +
               ", lifetimeRevenue=" + lifetimeRevenue +
               ", encryptedCPM='" + encryptedCPM + '\'' +
               '}';
    }
}