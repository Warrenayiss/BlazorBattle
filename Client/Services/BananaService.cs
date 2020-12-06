using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattle.Client.Services
{
	public class BananaService : IBananaService
	{
		public event Action OnChange;
		public int bananas { get; set; } = 1000;

		public void EatBananas(int amount)
		{
			bananas -= amount;
			BananaChanged();
			Console.WriteLine("Bananas eaten");
		}
		void BananaChanged() => OnChange.Invoke();

		public void AddBananas(int amount)
		{
			bananas += amount;
			BananaChanged();
		}
	}
}
