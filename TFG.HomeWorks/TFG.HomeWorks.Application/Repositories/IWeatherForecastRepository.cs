﻿using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastGetById;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastList;
using TFG.HomeWorks.Domain.Entities;

namespace TFG.HomeWorks.Application.Repositories
{
    internal interface IWeatherForecastRepository
    {
        Task<IEnumerable<WeatherForecast>> List(WeatherForecastListRequest request);
        void Add(WeatherForecast entity);
        Task<int> Count(WeatherForecastListRequest request);
        void Update(WeatherForecast entity);
        Task<WeatherForecast?> GetById(WeatherForecastGetByIdRequest request);
    }
}
