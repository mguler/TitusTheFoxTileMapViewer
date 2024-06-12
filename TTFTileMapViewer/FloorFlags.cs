namespace TTFTileMapViewer
{
	//x+256	256		Floor flags for each tile
	public enum FloorFlags
	{
		NoFloor = 0,
		Floor = 1,
		SlightlySlipperyFloor = 2,
		SlipperyFloor = 3,
		VerySlipperyFloor = 4,
		DropThrough = 5,
		Ladder = 6,
		HealthBonus = 7,
		DeadlyEatsMost = 8,
		DeadlyEatsAll = 9,
		DeadlySupportsAll = 10,
		LevelCode = 11,
		PadlockBonus = 12,
		Level14Code = 13
	}
}
