﻿using CSharpWars.DtoModel;
using CSharpWars.Scripting.Model;
using CSharpWars.ScriptProcessor.Moves;
using FluentAssertions;
using Xunit;

namespace CSharpWars.Tests.Scripting.Moves
{
    public class WalkForwardTests
    {
        [Fact]
        public void Building_A_Move_From_WalkForward_Move_Should_Create_An_Instance_Of_WalkForward()
        {
            // Arrange
            var bot = new BotDto { };
            var arena = new ArenaDto { Width = 1, Height = 1 };
            var botProperties = BotProperties.Build(bot, arena);
            botProperties.CurrentMove = Enums.Moves.WalkForward;

            // Act
            var move = Move.Build(botProperties);

            // Assert
            move.Should().NotBeNull();
            move.Should().BeOfType<WalkForward>();
        }
    }
}