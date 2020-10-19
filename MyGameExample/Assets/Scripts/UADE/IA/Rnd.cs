using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UADE.UI
{
    public static class Rnd
    {
        public static float RandomToNumber(float num)
        {
            return Random.value * num;
        }
        public static float RandomRange(float min, float max)
        {
            return Random.value * (max - min) + min;
        }
    }
}
