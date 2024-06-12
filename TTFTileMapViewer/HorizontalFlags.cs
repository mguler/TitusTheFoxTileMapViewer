using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TTFTileMapViewer
{
    //x	256		Horizontal flags for each tile

    public enum HorizontalFlags
    {
        NoWall = 0,
        Wall = 1,
        HealthBonus = 2,
        LevelCode = 4,
        PadlockBonus = 5,
        Level14Code = 6
    }
}
