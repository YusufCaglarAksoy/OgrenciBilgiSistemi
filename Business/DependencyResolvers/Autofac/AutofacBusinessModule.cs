using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BolumManager>().As<IBolumService>().SingleInstance();
            builder.RegisterType<EfBolumDal>().As<IBolumDal>().SingleInstance();

            builder.RegisterType<DersManager>().As<IDersService>().SingleInstance();
            builder.RegisterType<EfDersDal>().As<IDersDal>().SingleInstance();

            builder.RegisterType<DevamsizlikManager>().As<IDevamsizlikService>().SingleInstance();
            builder.RegisterType<EfDevamsizlikDal>().As<IDevamsizlikDal>().SingleInstance();

            builder.RegisterType<FakulteManager>().As<IFakulteService>().SingleInstance();
            builder.RegisterType<EfFakulteDal>().As<IFakulteDal>().SingleInstance();

            builder.RegisterType<HarcManager>().As<IHarcService>().SingleInstance();
            builder.RegisterType<EfHarcDal>().As<IHarcDal>().SingleInstance();

            builder.RegisterType<KullaniciFotografManager>().As<IKullaniciFotografService>().SingleInstance();
            builder.RegisterType<EfKullaniciFotografDal>().As<IKullaniciFotografDal>().SingleInstance();

            builder.RegisterType<MailManager>().As<IMailService>().SingleInstance();
            builder.RegisterType<EfMailDal>().As<IMailDal>().SingleInstance();

            builder.RegisterType<MufredatManager>().As<IMufredatService>().SingleInstance();
            builder.RegisterType<EfMufredatDal>().As<IMufredatDal>().SingleInstance();

            builder.RegisterType<NotManager>().As<INotService>().SingleInstance();
            builder.RegisterType<EfNotDal>().As<INotDal>().SingleInstance();

            builder.RegisterType<SinifListeManager>().As<ISinifListeService>().SingleInstance();
            builder.RegisterType<EfSinifListeDal>().As<ISinifListeDal>().SingleInstance();

            builder.RegisterType<SubeManager>().As<ISubeService>().SingleInstance();
            builder.RegisterType<EfSubeDal>().As<ISubeDal>().SingleInstance();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
