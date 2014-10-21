namespace WorldGridSharedTypes
{
    using System;

    public enum GameEventType
    {
        ACTIVE_BLOCK_PLACE_ON_GRID,
        ACTIVE_BLOCK_CHANGE_VALUE,
        ACTIVE_BLOCK_CHANGE_VISIBLE,
        ACTIVE_BLOCK_PHANTOM_VISIBLE,
        CLICK_ON_ZONE,
        CLICK_ON_ENCOUNTER,
        GRID_CHANGE,
        GRID_ZONE_COMPLETE,
        RESOURCES_CHANGE,
        ZONE_COMPLETE,
        ZONE_CHANGED_TERRAIN,
        ZONE_UPDATE_MATERIAL
    }
}

