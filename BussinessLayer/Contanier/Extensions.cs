using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Concrete.EnttiyFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Contanier
{
   public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {


            //services.AddScoped<IServiceService, ServiceManager>();
            //services.AddScoped<IServiceDal, EfServiceDal>();
            //services.AddScoped<ITeamService, TeamManager>();
            //services.AddScoped<ITeamDal, EfTeamDal>();
            //services.AddScoped<IAnnouncementService, AnnouncementManager>();
            //services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            //services.AddScoped<IImageService, ImageManager>();
            //services.AddScoped<IImageDal, EfImageDal>();
            //services.AddScoped<IAddressService, AddressManager>();
            //services.AddScoped<IAddressDal, EfAddressDal>();
            //services.AddScoped<IContactService, ContactManager>();
            //services.AddScoped<IContactDal, EfContactDal>();
            //services.AddScoped<ISocialMediaService, SocialMediaManager>();
            //services.AddScoped<ISocialMediaDal, EfSocailMediaDal>();
            //services.AddScoped<IAdminService, AdminManager>();
            //services.AddScoped<IAdminDal, EfAdminDal>();

            
        }
    }
}
