﻿using Microsoft.Extensions.DependencyInjection;

namespace TasksManagement.Data;
public static class Extensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection service)
    {
        //TODO: Add repositories to DI container

        return service;
    }
}
