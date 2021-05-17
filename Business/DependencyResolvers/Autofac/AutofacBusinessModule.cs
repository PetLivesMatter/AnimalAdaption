using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AnimalManager>().As<IAnimalService>().SingleInstance();
            builder.RegisterType<EfAnimalDal>().As<IAnimalDal>().SingleInstance();

            builder.RegisterType<AdvertisementManager>().As<IAdvertisementService>().SingleInstance();
            builder.RegisterType<EfAdvertisementDal>().As<IAdvertisementDal>().SingleInstance();


        }
    }
}
