using System;

namespace GameUtils
{
	public class Dice : Random
	{
		public Dice (int seed) : base(seed)
		{
		}
		
		public Dice ()
		{
		}
		
		public int Roll (int throws)
		{
			int result = 0;
			for (int i=0; i<throws; i++) {
				result += this.Next (1, 7);
			}
			return result;
		}
	}
}

