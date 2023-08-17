using UnityEngine;

public class ChapterSystem : MonoBehaviour
{
    public void Restart()
    {
        IronSource.Agent.showInterstitial(null, null);
    }

    public void Next()
    {
        IronSource.Agent.showInterstitial(null, null);
    }
}