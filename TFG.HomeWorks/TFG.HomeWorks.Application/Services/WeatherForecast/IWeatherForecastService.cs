﻿using TFG.HomeWorks.Application.Base;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastCreate;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastGetById;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastList;
using TFG.HomeWorks.Application.Services.WeatherForecast.DTOs.WeatherForecastUpdate;

namespace TFG.HomeWorks.Application.Services.WeatherForecast
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecastCreateResponse> Create(WeatherForecastCreateRequest request);
        Task<WeatherForecastGetByIdResponse> GetById(WeatherForecastGetByIdRequest request);
        Task<PageListResponse<WeatherForecastListItemResponse>> List(WeatherForecastListRequest request);
        System.Threading.Tasks.Task Update(WeatherForecastUpdateRequest request);
    }
}