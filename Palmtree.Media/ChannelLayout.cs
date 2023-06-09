﻿using System;

namespace Palmtree.Media
{
    [Flags]
    public enum ChannelLayout
    {
        SPEAKER_NONE = 0,
        SPEAKER_FRONT_LEFT = 0x1,
        SPEAKER_FRONT_RIGHT = 0x2,
        SPEAKER_FRONT_CENTER = 0x4,
        SPEAKER_LOW_FREQUENCY = 0x8,
        SPEAKER_BACK_LEFT = 0x10,
        SPEAKER_BACK_RIGHT = 0x20,
        SPEAKER_FRONT_LEFT_OF_CENTER = 0x40,
        SPEAKER_FRONT_RIGHT_OF_CENTER = 0x80,
        SPEAKER_BACK_CENTER = 0x100,
        SPEAKER_SIDE_LEFT = 0x200,
        SPEAKER_SIDE_RIGHT = 0x400,
        SPEAKER_TOP_CENTER = 0x800,
        SPEAKER_TOP_FRONT_LEFT = 0x1000,
        SPEAKER_TOP_FRONT_CENTER = 0x2000,
        SPEAKER_TOP_FRONT_RIGHT = 0x4000,
        SPEAKER_TOP_BACK_LEFT = 0x8000,
        SPEAKER_TOP_BACK_CENTER = 0x10000,
        SPEAKER_TOP_BACK_RIGHT = 0x20000,

        AUDIO_SPEAKER_MONO = SPEAKER_FRONT_CENTER,
        AUDIO_SPEAKER_1POINT1 = SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY,
        AUDIO_SPEAKER_STEREO = SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT,
        AUDIO_SPEAKER_2POINT1 = SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_LOW_FREQUENCY,
        AUDIO_SPEAKER_3POINT0 = SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER,
        AUDIO_SPEAKER_3POINT1 = SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY,
        AUDIO_SPEAKER_QUAD = SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT,
        AUDIO_SPEAKER_SURROUND = SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_BACK_CENTER,
        AUDIO_SPEAKER_5POINT0 = SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_SIDE_LEFT | SPEAKER_SIDE_RIGHT,
        AUDIO_SPEAKER_5POINT1 = SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT,
        AUDIO_SPEAKER_7POINT0 = SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT | SPEAKER_SIDE_LEFT | SPEAKER_SIDE_RIGHT,
        AUDIO_SPEAKER_7POINT1 = SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT | SPEAKER_FRONT_LEFT_OF_CENTER | SPEAKER_FRONT_RIGHT_OF_CENTER,
        AUDIO_SPEAKER_5POINT1_SURROUND = SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_SIDE_LEFT | SPEAKER_SIDE_RIGHT,
        AUDIO_SPEAKER_7POINT1_SURROUND = SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT | SPEAKER_SIDE_LEFT | SPEAKER_SIDE_RIGHT,
        AUDIO_SPEAKER_5POINT1_BACK = AUDIO_SPEAKER_5POINT1,
        AUDIO_SPEAKER_7POINT1_WIDE = AUDIO_SPEAKER_7POINT1,
    }
}
