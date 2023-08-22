using Game.Scripts;
using UnityEngine;
using Zenject;

public class ProjectInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
#if UNITY_EDITOR
        Container
            .Bind<IAdvertisementService>()
            .To<NullAdvertisementService>()
            .AsSingle()
            .NonLazy();
#else
            if (testGroup == "A")
            {
                Container
                    .Bind<IAdvertisementService>()
                    .To<AppLovinAdvertisementService>()
                    .AsSingle()
                    .NonLazy();
            }
            else // Test Group B
            {
                Container
                    .Bind<IAdvertisementService>()
                    .To<IronSourceAdvertisementService>()
                    .AsSingle()
                    .NonLazy();
            }
#endif

        Container.Bind<MissionSystem>().AsSingle().NonLazy();
        Container.Bind<LevelSystem>().AsSingle().NonLazy();
        Container.Bind<ChapterSystem>().AsSingle().NonLazy();
        Container.Bind<CurrencySystem>().AsSingle().NonLazy();

        Container.BindFactory<Object, Enemy, Enemy.FactoryInterface>()
            .FromFactory<Enemy.FactoryImplementation>();
    }
}