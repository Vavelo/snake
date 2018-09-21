using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace змейка
{
    class Walls
    {
        List<FR> wallList;

		public Walls( int mapW, int mapH )
		{
			wallList = new List<FR>();

			// Отрисовка рамочки
			HLine upLine = new HLine( 0, mapW - 2, 0, '+' );
			HLine downLine = new HLine( 0, mapW - 2, mapH - 1, '+' );
			VLine leftLine = new VLine( 0, mapH - 1, 0, '+' );
			VLine rightLine = new VLine( 0, mapH - 1, mapW - 2, '+' );

			wallList.Add( upLine );
			wallList.Add( downLine );
			wallList.Add( leftLine );
			wallList.Add( rightLine );
		}

		internal bool IsHit( FR figure )
		{
			foreach(var wall in wallList)
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
			foreach ( var wall in wallList )
			{
				wall.Draw();
			}
		}
	}
}