using Unity.Entities;

public struct SpaceSatellite : IComponentData
{
    public Entity OrbitingEntity;
    public float OrbitRadius;
    public float OrbitSpeed;
    public float OrbitOffset;
    public float OrbitInclination;
    public float OrbitPhase;
    public float OrbitTilt;
    public float OrbitEccentricity;
    public float OrbitPeriod;
    public float OrbitTime;
    public float OrbitRotation;
    public float OrbitRotationSpeed;
    public float OrbitRotationOffset;
    public float OrbitRotationInclination;
    public float OrbitRotationPhase;
    public float OrbitRotationTilt;
    public float OrbitRotationEccentricity;
    public float OrbitRotationPeriod;
    public float OrbitRotationTime;
    public float OrbitRotationRadius;
}