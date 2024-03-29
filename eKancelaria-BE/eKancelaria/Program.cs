﻿using LegalOffice.Domain;
using LegalOffice.Domain.Models;
using LegalOffice.Repository;
using LegalOffice.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using eKancelaria.Controllers;
using GusApi;
using System.Configuration;
using eCourt;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.Configure<ECourtSettings>(builder.Configuration.GetSection("ECourt"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRepository<GroundTemplate>, Repository<GroundTemplate>>();
builder.Services.AddScoped<IPlaintiffRepository, PlaintiffRepository>();
builder.Services.AddScoped<IPlaintiffService, PlaintiffService>();
builder.Services.AddScoped<IObslugaGus, ObslugaGus>();
builder.Services.AddScoped<ILawsuitRepository, LawsuitRepository>();
builder.Services.AddScoped<ILawsuitService,LawsuitService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
builder.Services.AddDbContext<LegalOfficeDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LegalOfficeDatabase")));

var app = builder.Build();
app.UseCors("CorsPolicy");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
