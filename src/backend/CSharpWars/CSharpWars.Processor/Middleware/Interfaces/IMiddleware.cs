﻿namespace CSharpWars.Processor.Middleware.Interfaces;

public interface IMiddleware
{
    Task Process();
}