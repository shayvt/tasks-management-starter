﻿using Microsoft.AspNetCore.Mvc;
using TasksManagement.Domain.Models;
using TasksManagement.Domain.Services;

namespace TasksManagement.Web;

public static class EndpointsExtension
{
    public static void MapEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("api/v1");

        //TODO: Map the 3 apis endpoints

        //group.MapGet("/tasks" ...)
        //     .AddEndpointFilter<LoggingFilter>()
        //     .WithOpenApi();

        //group.MapGet("/tasks/{id}" ...)
        //     .AddEndpointFilter<LoggingFilter>()
        //     .WithOpenApi();

        //group.MapPost("/tasks", ...)
        //     .AddEndpointFilter<LoggingFilter>()
        //     .WithOpenApi();
    }

    //TODO: You can implement and use this method for mapping Result to Api IResult
    //public static IResult GetHttpResult<T>(this Result<T> result)
    //{
    //}
}