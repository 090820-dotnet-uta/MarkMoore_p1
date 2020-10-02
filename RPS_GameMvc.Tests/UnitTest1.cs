using System;
using Xunit;
using RPS_GameMvc.Models;
using RPS_GameMvc.GamePlay;

namespace RPS_GameMvc.Tests
{
	public class UnitTest1
	{

		
		[Fact]
		public void Test1()
		{
			Assert.Equal(1,1);
		}

		[Fact]
		public void GameAddPlayerReturnsThePlayer()
		{
			//Arrange
			Rps_Game rpsgame = new Rps_Game();
			Player p = new Player()
			{
				Name = "jim jim",
				Losses = 2,
				Wins = 4
			};

			//act
			Player q = rpsgame.GameAddPlayer(p);

			//assert
			Assert.Equal("jim jim", q.Name);

		}
	}
}
