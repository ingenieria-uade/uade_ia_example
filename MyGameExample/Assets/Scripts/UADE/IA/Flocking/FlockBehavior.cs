using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UADE.IA.Flocking
{
    public abstract class FlockBehavior : MonoBehaviour
    {
        public abstract Vector3 CalculateDirection(List<Transform> context);
    }
}
