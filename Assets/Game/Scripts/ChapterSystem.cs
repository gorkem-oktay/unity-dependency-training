using Game.Scripts;
using UnityEngine;

public class ChapterSystem
{
    private IAdvertisementService _advertisementService;

    public ChapterSystem(IAdvertisementService advertisementService)
    {
        _advertisementService = advertisementService;
    }

    private void Awake()
    {
    }

    private void Start()
    {
    }

    public void Restart()
    {
        Debug.Log($"Chapter restarted");

        _advertisementService.showInterstitial(null, null);
    }

    public void Next()
    {
        Debug.Log($"Proceeded to the next chapter");

        _advertisementService.showInterstitial(null, null);
    }
}