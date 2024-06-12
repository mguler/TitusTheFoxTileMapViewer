using System;
using System.Diagnostics;

namespace TTFTileMapViewer
{
    public class TileTool
    {
        public static IEnumerable<Size> GetSizes(byte[] data) 
        {
            for (int index = 0; index < data.Length; index+=2) 
            {
                yield return new Size
                {
                    Width = (int)data[index],
                    Height = (int)data[index + 1]
                };
            }
        }

        public static Bitmap[] GetTileBitmaps(byte[] data)
        {
            var palette = new Color[]  {
                Color.FromArgb(0,0,0)
                ,Color.FromArgb(255,255,255)
                ,Color.FromArgb(0,0,0)
                ,Color.FromArgb(97,32,0)
                ,Color.FromArgb(113,65,0)
                ,Color.FromArgb(162,97,65)
                ,Color.FromArgb(195,162,97)
                ,Color.FromArgb(243,195,130)
                ,Color.FromArgb(65,32,0)
                ,Color.FromArgb(113,81,81)
                ,Color.FromArgb(162, 130, 130)
                ,Color.FromArgb(48, 48, 113)
                ,Color.FromArgb(97, 97, 162)
                ,Color.FromArgb(130, 130, 195)
                ,Color.FromArgb(0, 65,0)
                ,Color.FromArgb(32,32,97)
            };

            var result = new List<Bitmap>();

            for (var tileIndex = 0; tileIndex < 255; tileIndex++)
            {
                var bitmap = new Bitmap(16, 16);
                result.Add(bitmap);
                var graphics = Graphics.FromImage(bitmap);
                var y = 0;

                for (var index = 0; index < 32; index += 2)
                {
                    var x = 0;
                    for (var lineIndex = 0; lineIndex < 2; lineIndex++)
                    {
                        for (var bitIndex = 7; bitIndex >= 0; bitIndex--)
                        {
                            var colorIndex =
                                (data[index + lineIndex + tileIndex * 128] & (1 << bitIndex)) >> bitIndex
                                | ((data[index + lineIndex + tileIndex * 128 + 32] & (1 << bitIndex)) >> bitIndex) << 1
                                | ((data[index + lineIndex + tileIndex * 128 + 64] & (1 << bitIndex)) >> bitIndex) << 2
                                | ((data[index + lineIndex + tileIndex * 128 + 96] & (1 << bitIndex)) >> bitIndex) << 3;

                            var color = palette[colorIndex];
                            x++;
                            graphics.FillRectangle(new SolidBrush(color)
                                , x, y, 1, 1);
                        }
                    }
                    y++;
                }
            }
            return result.ToArray();
        }

        public static Bonus[] GetBonusses(byte[] data)
        {
            var result = new List<Bonus>();

            for (var index = 0; index < 400; index += 4)
            {
                var bonus = new Bonus
                {
                    SpriteNumber = data[index],
                    SpriteNumberToBeReplaced = data[index + 1],
                    X = data[index + 2],
                    Y = data[index + 3]
                };
                result.Add(bonus);
            }
            return result.ToArray();
        }

        public static GameObject[] GetGameObjects(byte[] data)
        {
            var result = new List<GameObject>();

            for (var index = 0; index < 40; index += 4)
            {
                var bonus = new GameObject
                {
                    SpriteNumber = data[index] >> 4 | data[index+1],
                    X = data[index + 2],
                    Y = data[index + 3]
                };
                result.Add(bonus);
            }
            return result.ToArray();
        }

        public static Tile[] GetTiles(byte[] data)
        {
            var palette = new Color[]  {
                Color.FromArgb(0,0,0)
                ,Color.FromArgb(255,255,255)
                ,Color.FromArgb(0,0,0)
                ,Color.FromArgb(97,32,0)
                ,Color.FromArgb(113,65,0)
                ,Color.FromArgb(162,97,65)
                ,Color.FromArgb(195,162,97)
                ,Color.FromArgb(243,195,130)
                ,Color.FromArgb(65,32,0)
                ,Color.FromArgb(113,81,81)
                ,Color.FromArgb(162, 130, 130)
                ,Color.FromArgb(48, 48, 113)
                ,Color.FromArgb(97, 97, 162)
                ,Color.FromArgb(130, 130, 195)
                ,Color.FromArgb(0, 65,0)
                ,Color.FromArgb(32,32,97)
            };

            var result = new List<Tile>();

            var horizontalFlagsIndex = 256 * 128;
            var floorFlagsIndex = horizontalFlagsIndex + 256;
            var ceilingFlagsIndex = horizontalFlagsIndex + 512;

            for (var tileIndex = 0; tileIndex < 256; tileIndex++)
            {
                var tile = new Tile
                {
                    ImageData = new Bitmap(16, 16),
                    Wall = (HorizontalFlags)data[horizontalFlagsIndex + tileIndex],
                    Floor = (FloorFlags)data[floorFlagsIndex + tileIndex],
                    Ceiling = (CeilingFlags)data[ceilingFlagsIndex + tileIndex]
                };

                result.Add(tile);
                var graphics = Graphics.FromImage(tile.ImageData);
                var y = 0;

                for (var index = 0; index < 32; index += 2)
                {
                    var x = 0;
                    for (var lineIndex = 0; lineIndex < 2; lineIndex++)
                    {
                        for (var bitIndex = 7; bitIndex >= 0; bitIndex--)
                        {
                            var colorIndex =
                                (data[index + lineIndex + tileIndex * 128] & (1 << bitIndex)) >> bitIndex
                                | ((data[index + lineIndex + tileIndex * 128 + 32] & (1 << bitIndex)) >> bitIndex) << 1
                                | ((data[index + lineIndex + tileIndex * 128 + 64] & (1 << bitIndex)) >> bitIndex) << 2
                                | ((data[index + lineIndex + tileIndex * 128 + 96] & (1 << bitIndex)) >> bitIndex) << 3;

                            var color = palette[colorIndex];
                            x++;
                            graphics.FillRectangle(new SolidBrush(color)
                                , x, y, 1, 1);
                        }
                    }
                    y++;
                }
            }
            return result.ToArray();
        }
    }


}
