using Unity.Mathematics;
using Unity.NetCode;
using Unity.Transforms;

namespace NetCube
{
    [GhostComponentVariation(typeof(Translation), "TranslationPrecisionVariant")]
    [GhostComponent(PrefabType = GhostPrefabType.All, OwnerPredictedSendType = GhostSendType.All, SendDataForChildEntity = false)]
    public struct TranslationPrecisionVariant
    {

            [GhostField(Quantization=100000, Smoothing=SmoothingAction.Interpolate, SubType=0)] public float3 Value;

    }
}