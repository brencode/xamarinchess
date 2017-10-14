using System;
namespace XamarinChess.Model
{
    public struct XYCoordinate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:XamarinChess.Models.Coordinate"/> struct.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        public XYCoordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Gets the x value.
        /// </summary>
        /// <value>The x.</value>
        public int X { get; }

        /// <summary>
        /// Gets the y value.
        /// </summary>
        /// <value>The y.</value>
        public int Y { get; }

    }
}
