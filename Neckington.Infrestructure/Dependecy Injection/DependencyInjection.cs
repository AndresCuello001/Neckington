using Microsoft.Extensions.DependencyInjection;
using Neckington.Domain.Interfaces;
using Neckington.Data;
using Neckington.Data.Repositories;
using Neckington.Domain.Entities;
using Neckington.Application.Features.Contacts;
using Neckington.Application.Features.Contacts.CreateContact;
using Neckington.Application.Features.Contacts.DeleteContact;
using Neckington.Application.Features.Contacts.UpdateContact;
using Neckington.Application.Features.Contacts.ReadContacts;

namespace Neckington.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddDbContext<ContactDbContext>();

            services.AddScoped<IContactRepository<Contact>, ContactRepository<Contact>>();

            services.AddScoped<CreateContactUseCases>();
            services.AddScoped<DeleteContactsByEmail>();
            services.AddScoped<UpdateContactsById>();
            services.AddScoped<GetallContacts>();
            return services;
        } 
    }
}