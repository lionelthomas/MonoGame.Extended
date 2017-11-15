using Microsoft.Xna.Framework;

namespace MonoGame.Extended.Tiled
{
    public sealed class TiledMapTileObject : TiledMapObject
    {
        public TiledMapTileObject(int identifier, string name, TiledMapTileset tileset, TiledMapTilesetTile tile, 
            Size2 size, Vector2 position, float rotation = 0, float opacity = 1, bool isVisible = true) 
            : base(identifier, name, size, position, rotation, opacity, isVisible)
        {
            Tileset = tileset;
            Tile = tile;
        }

        public TiledMapTilesetTile Tile { get; }
        public TiledMapTileset Tileset { get; }
        public override TiledMapObjectType Type => TiledMapObjectType.Tile;
    }
}
