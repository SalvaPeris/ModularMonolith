global using Microsoft.EntityFrameworkCore;
global using System.Reflection;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using FluentValidation;
global using MediatR;
global using Mapster;
global using Carter;
global using Microsoft.AspNetCore.Http; 
global using Microsoft.AspNetCore.Routing;

global using Shared.Data;
global using Shared.DDD;
global using Shared.Data.Seed;
global using Shared.Contracts.CQRS;
global using Shared.Behaviors;
global using Shared.Data.Interceptors;

global using Catalog.Products.Models;
global using Catalog.Products.Events;
global using Catalog.Data;
global using Catalog.Data.Seed;
global using Catalog.Products.Exceptions;
global using Catalog.Contracts.Products.Features.GetProductById;
global using Catalog.Contracts.Products.Dtos;

