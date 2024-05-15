using System;
using Core.Utilities;
using UnityEngine;
using VContainer;
using VContainer.Unity;
using Logger = Core.Utilities.Logger;

public class TestLifetimeScope : LifetimeScope
{
    [SerializeField] private TestMonoBehaviour testMonoBehaviour;
    
    protected override void Configure(IContainerBuilder builder)
    {
        //builder.Register<Logger>(Lifetime.Singleton);
        //builder.Register<Calulator>(Lifetime.Singleton);
        //builder.Register<HogeClass>(Lifetime.Singleton);

        //builder.RegisterComponent(testMonoBehaviour);

        builder.Register<EntryPointSample>(Lifetime.Singleton);
        
        builder.RegisterBuildCallback(objectResolver =>
        {
            objectResolver.Resolve<EntryPointSample>();
        });
    }
}
