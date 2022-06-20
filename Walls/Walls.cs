using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeVS
{
    class Walls
	{
		List<Figure> WallList;

		public Walls(int mapWidth, int mapHeight)
		{
			WallList = new List<Figure>();


			HorisontalLine upLine = new HorisontalLine(0, mapWidth - 2, 0, '+');
			HorisontalLine downLine = new HorisontalLine(0, mapWidth - 2, mapHeight - 1, '+');
			VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
			VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

			WallList.Add(upLine);
			WallList.Add(downLine);
			WallList.Add(leftLine);
			WallList.Add(rightLine);
		}

		internal bool IsHit(Figure figure)
		{
			foreach (var wall in WallList)
			{
				if (wall.IsHit(figure))
				{
					return true;
				}
			}
			return false;
		}

		public void Draw()
		{
			foreach (var wall in WallList)
			{
				wall.Draw();
			}
		}
	}
}