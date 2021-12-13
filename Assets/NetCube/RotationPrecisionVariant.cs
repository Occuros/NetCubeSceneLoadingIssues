using Unity.Mathematics;
using Unity.NetCode;
using Unity.Transforms;

namespace NetCube
{
    [GhostComponentVariation(typeof(Rotation), "TranslationPrecisionVariant")]
    [GhostComponent(PrefabType = GhostPrefabType.All, OwnerPredictedSendType = GhostSendType.All, SendDataForChildEntity = false)]
    public struct RotationPrecisionVariant
    {
            [GhostField(Quantization=100000, Smoothing=SmoothingAction.Interpolate, SubType=0)] public quaternion Value;
    }
}