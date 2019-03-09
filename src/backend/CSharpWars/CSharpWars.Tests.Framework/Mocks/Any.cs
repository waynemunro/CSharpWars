﻿using System;
using System.Linq.Expressions;
using Moq;

namespace CSharpWars.Tests.Framework.Mocks
{
    public static class Any
    {
        public static Expression<Func<TModel, Boolean>> Predicate<TModel>()
        {
            return It.IsAny<Expression<Func<TModel, Boolean>>>();
        }
    }
}