using UnityEngine;

public class ChapterSystem : MonoBehaviour
{
    public void Restart()
    {
        Debug.Log($"Chapter restarted");

        IronSource.Agent.showInterstitial(null, null);
    }

    public void Next()
    {
        Debug.Log($"Proceeded to the next chapter");

        IronSource.Agent.showInterstitial(null, null);
    }
}