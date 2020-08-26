using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame;
using PonderingProgrammer.GridMap;

namespace PonderingProgrammer.GridMapSamples
{
    public class GridMapSprite
    {
        private const int OriginX = 0;
        private const int OriginY = 0;
        
        private readonly IGridMap _gridMap;
        private readonly int _scale;
        
        private Texture2D _tex;

        public GridMapSprite(IGridMap gridMap, int scale)
        {
            _gridMap = gridMap;
            _scale = scale;
        }
        
        public void Draw(SpriteBatch spriteBatch)
        {
            if (spriteBatch == null) throw new ArgumentNullException(nameof(spriteBatch));
            
            var bb = _gridMap.Bounds;
            var bbRect = new Rectangle(bb.MinX * _scale, bb.MinY * _scale, bb.Width * _scale, bb.Height * _scale);
            spriteBatch.Draw(_tex, bbRect, Color.White);
        }

        /// <summary>
        ///     Expensive. Don't call in game loop.
        /// </summary>
        /// <param name="gd"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void UpdateTexture(GraphicsDevice gd)
        {
            if (gd == null) throw new ArgumentNullException(nameof(gd));
            var bb = _gridMap.Bounds;
            var renderTarget = new RenderTarget2D(gd, bb.Width * _scale, bb.Height * _scale);
            var spriteBatch = new SpriteBatch(gd);
            gd.SetRenderTarget(renderTarget);
            gd.Clear(Color.CornflowerBlue);
            
            spriteBatch.Begin();

            spriteBatch.FillRectangle(OriginX * _scale, OriginY * _scale, bb.Width * _scale, bb.Height * _scale, Color.Black);

            DrawAreas(spriteBatch);

            for (var y = 0; y < bb.Height; y++)
            {
                spriteBatch.DrawLine(OriginX * _scale, y * _scale, (OriginX + bb.Width) * _scale, y * _scale, Color.WhiteSmoke);
            }
            for (var x = 0; x < bb.Width; x++)
            {
                spriteBatch.DrawLine(x * _scale, OriginY * _scale, x * _scale, (OriginY + bb.Height) * _scale, Color.WhiteSmoke);
            }
            
            spriteBatch.End();
            gd.SetRenderTarget(null);
            spriteBatch.Dispose();
            _tex = renderTarget;
        }

        private void DrawAreas(SpriteBatch spriteBatch)
        {
            foreach (var area in _gridMap.Areas)
            {
                foreach (var interiorCoordinates in area.Shape.Interior)
                {
                    spriteBatch.FillRectangle(interiorCoordinates.X * _scale, interiorCoordinates.Y * _scale, _scale, _scale, Color.Bisque);
                }
            }
        }
    }
}