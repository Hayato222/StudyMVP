using VContainer;
using VContainer.Unity;

namespace Core.Utilities
{
    public sealed class TestLifeTimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<Logger>(Lifetime.Singleton);
            builder.Register<Calulator>(Lifetime.Singleton);
            builder.Register<HogeClass>(Lifetime.Singleton);
        }
        
    }
}