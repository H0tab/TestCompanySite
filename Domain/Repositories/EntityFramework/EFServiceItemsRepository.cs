using Microsoft.EntityFrameworkCore;
using MyCompanySite2.Domain.Entities;
using MyCompanySite2.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompanySite2.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsRepository : IServiceItemsRepository
    {
        private readonly AppDbContext context;

        public EFServiceItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteServiceItem(Guid id)
        {
            context.ServieItems.Remove(new ServiceItem() { Id = id });
            context.SaveChanges();
        }

        public ServiceItem GetServiceItemById(Guid id)
        {
            return context.ServieItems.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return context.ServieItems;
        }

        public void SaveServiceItem(ServiceItem entity)
        {
            if(entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}
