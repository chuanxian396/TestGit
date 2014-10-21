namespace WorldGridLogic
{
    using System;

    [Flags]
    public enum PosAround
    {
        ALL_CORNERS = 240,
        ALL_SIDES = 15,
        BL_CORNER = 0x80,
        BLOCKED_POS1 = 10,
        BLOCKED_POS2 = 0x38,
        BOTTOM = 8,
        BR_CORNER = 0x40,
        CORNER_IN = 0x20,
        CORNER_OUT_1 = 20,
        CORNER_OUT_2 = 0x84,
        CORNER_OUT_3 = 80,
        CORNER_OUT_4 = 6,
        LEFT = 1,
        LEFT_AND_RIGHT = 5,
        LINE_1 = 0x30,
        LINE_2 = 2,
        NONE = 0,
        RIGHT = 4,
        TL_CORNER = 0x10,
        TOP = 2,
        TOP_AND_BOTTOM = 10,
        TR_CORNER = 0x20
    }
}

