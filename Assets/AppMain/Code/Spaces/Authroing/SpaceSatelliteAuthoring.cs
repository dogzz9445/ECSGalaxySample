using UnityEngine;
using Unity.Entities;

namespace Galaxy
{
    public class SpaceSatelliteAuthoring : MonoBehaviour
    {
        
        class Baker : Baker<SpaceSatelliteAuthoring>
        {
            public override void Bake(SpaceSatelliteAuthoring authoring)
            {
                Entity entity = GetEntity(authoring, TransformUsageFlags.Dynamic);
                // AddComponent(entity, new Ship
                // {
                //     ShipData = BlobAuthoringUtility.BakeToBlob(this, authoring.ShipData),
                    
                //     AccelerationMultiplier = 1f,
                //     MaxSpeedMultiplier = 1f,
                // });
            }
        }
    }
}
