namespace TTFTileMapViewer
{
    /// <summary>
    ///         x+2716	20*7		Gates
    /// Offset Size What it is
    /// -----------------------------
    /// 0	2	X/Y coordinates of entrance
    /// 2	2	X/Y coordinates of screen position after passing through a gate
    /// 4	2	X/Y coordinates of exit
    /// 6	1	Scrolling; if this is non-zero, scrolling is disabled after passing through
    /// <summary>
    /// Offset Size What it is
    /// -----------------------------
    /// </summary>

    public class Gate
    {
        /// X coordinates of entrance
        public int EntranceX { get; set; }
        public int EntranceY { get; set; }
        /// X coordinates of screen position after passing through a gate
        public int ScreenX { get; set; }
        /// Y coordinates of screen position after passing through a gate
        public int ScreenY { get; set; }
        /// X coordinates of exit
        public int ExitX { get; set; }
        /// Y coordinates of exit
        public int ExitY { get; set; }
        /// <summary>
        /// if this is true, scrolling is disabled after passing through
        /// </summary>
        public bool Scrolling { get; set; }
    }
}
