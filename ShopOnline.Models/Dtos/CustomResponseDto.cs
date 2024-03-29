﻿using System.Text.Json.Serialization;

namespace ShopOnline.Models.Dtos;

public class CustomResponseDto<T>
{
    public T Data { get; set; }

    [JsonIgnore] public int StatusCode { get; set; }

    public List<string> Errors { get; set; } = new List<string>();

    public static CustomResponseDto<T> Success(int statusCode, T data)
    {
        return new CustomResponseDto<T> { Data = data, StatusCode = statusCode };
    }

    // Returning Success without any data
    public static CustomResponseDto<T> Success(int statusCode)
    {
        return new CustomResponseDto<T> { StatusCode = statusCode };
    }

    public static CustomResponseDto<T> Fail(int statusCode, List<string> errors)
    {
        return new CustomResponseDto<T> { StatusCode = statusCode, Errors = errors };
    }

    // Returning Fail with only 1 error
    public static CustomResponseDto<T> Fail(int statusCode, string error)
    {
        return new CustomResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error } };
    }
}