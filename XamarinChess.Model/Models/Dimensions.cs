using System;
namespace XamarinChess.Model.Models
{
    public struct Dimensions
    {
        public Dimensions(int length, int width)
        {
            Length = length;
            Width = width;
        }
        public int Length { get; }

        public int Width { get; }
    }
}
