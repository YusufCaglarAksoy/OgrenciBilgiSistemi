using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AkademisyenManager>().As<IAkademisyenService>().SingleInstance();
            builder.RegisterType<EfAkademisyenDal>().As<IAkademisyenDal>().SingleInstance();

            builder.RegisterType<BolumManager>().As<IBolumService>().SingleInstance();
            builder.RegisterType<EfBolumDal>().As<IBolumDal>().SingleInstance();

            builder.RegisterType<DersManager>().As<IDersService>().SingleInstance();
            builder.RegisterType<EfDersDal>().As<IDersDal>().SingleInstance();

            builder.RegisterType<DersKayitManager>().As<IDersKayitService>().SingleInstance();
            builder.RegisterType<EfDersKayitDal>().As<IDersKayitDal>().SingleInstance();

            builder.RegisterType<DevamsizlikManager>().As<IDevamsizlikService>().SingleInstance();
            builder.RegisterType<EfDevamsizlikDal>().As<IDevamsizlikDal>().SingleInstance();

            builder.RegisterType<FakulteManager>().As<IFakulteService>().SingleInstance();
            builder.RegisterType<EfFakulteDal>().As<IFakulteDal>().SingleInstance();

            builder.RegisterType<HarcManager>().As<IHarcService>().SingleInstance();
            builder.RegisterType<EfHarcDal>().As<IHarcDal>().SingleInstance();

            builder.RegisterType<AkademisyenFotografManager>().As<IAkademisyenFotografService>().SingleInstance();
            builder.RegisterType<EfAkademisyenFotografDal>().As<IAkademisyenFotografDal>().SingleInstance();

            builder.RegisterType<IdareciFotografManager>().As<IIdareciFotografService>().SingleInstance();
            builder.RegisterType<EfIdareciFotografDal>().As<IIdareciFotografDal>().SingleInstance();

            builder.RegisterType<OgrenciFotografManager>().As<IOgrenciFotografService>().SingleInstance();
            builder.RegisterType<EfOgrenciFotografDal>().As<IOgrenciFotografDal>().SingleInstance();

            builder.RegisterType<MailManager>().As<IMailService>().SingleInstance();
            builder.RegisterType<EfMailDal>().As<IMailDal>().SingleInstance();

            builder.RegisterType<MufredatManager>().As<IMufredatService>().SingleInstance();
            builder.RegisterType<EfMufredatDal>().As<IMufredatDal>().SingleInstance();

            builder.RegisterType<NotManager>().As<INotService>().SingleInstance();
            builder.RegisterType<EfNotDal>().As<INotDal>().SingleInstance();

            builder.RegisterType<OgrenciManager>().As<IOgrenciService>().SingleInstance();
            builder.RegisterType<EfOgrenciDal>().As<IOgrenciDal>().SingleInstance();

            builder.RegisterType<SinavManager>().As<ISinavService>().SingleInstance();
            builder.RegisterType<EfSinavDal>().As<ISinavDal>().SingleInstance();

            builder.RegisterType<SinifListeManager>().As<ISinifListeService>().SingleInstance();
            builder.RegisterType<EfSinifListeDal>().As<ISinifListeDal>().SingleInstance();

            builder.RegisterType<SubeManager>().As<ISubeService>().SingleInstance();
            builder.RegisterType<EfSubeDal>().As<ISubeDal>().SingleInstance();

            builder.RegisterType<IdareciManager>().As<IIdareciService>().SingleInstance();
            builder.RegisterType<EfIdareciDal>().As<IIdareciDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
