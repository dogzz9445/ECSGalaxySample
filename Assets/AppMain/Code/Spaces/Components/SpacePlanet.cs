using UnityEngine;

using Unity.Entities;

namespace Galaxy
{
    public struct SpacePlanet : IComponentData
    {
        public float Mass;
        public float Radius;
        public float Gravity;
        public float RotationSpeed;
        public float OrbitSpeed;
        public float OrbitRadius;
        public float OrbitOffset;
        public float OrbitInclination;
        public float OrbitPhase;
        public float OrbitTilt;
        public float OrbitEccentricity;
        public float OrbitPeriod;
        public float OrbitTime;
    }
}

