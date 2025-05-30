﻿using System.Runtime.InteropServices;

namespace MouseJigglerGUI
{
    [Flags]
    public enum EXECUTION_STATE : uint
    {
        ES_AWAYMODE_REQUIRED = 0x00000040,
        ES_CONTINUOUS = 0x80000000,
        ES_DISPLAY_REQUIRED = 0x00000002,
        ES_SYSTEM_REQUIRED = 0x00000001
    }

    public enum MouseMode
    {
        Real,
        Virtual
    }
}
