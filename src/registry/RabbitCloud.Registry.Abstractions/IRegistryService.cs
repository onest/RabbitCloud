﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace RabbitCloud.Registry.Abstractions
{
    public interface IRegistryService
    {
        Task RegisterAsync(ServiceRegistryDescriptor descriptor);

        Task UnRegisterAsync(ServiceRegistryDescriptor descriptor);

        Task SetAvailableAsync(ServiceRegistryDescriptor descriptor);

        Task SetUnAvailableAsync(ServiceRegistryDescriptor descriptor);

        IReadOnlyCollection<ServiceRegistryDescriptor> GetRegisteredServices();
    }
}