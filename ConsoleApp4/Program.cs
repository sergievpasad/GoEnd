using Castle.Facilities.Startable;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;

namespace GoEnd;

public class Program
{
    private static IWindsorContainer _container = new WindsorContainer();

    public static void Main()
    {
        try
        {
            Start();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }

    private static void Start()
    {
        _container.AddFacility<StartableFacility>(f => f.DeferredStart());
        _container.Kernel.Resolver.AddSubResolver(new CollectionResolver(_container.Kernel));
        _container.Install(new LocalInstaller());
    }
}
