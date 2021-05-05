
using Unity.Entities;
using Unity.NetCode;
using Unity.Networking.Transport;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public struct CubeInput : ICommandData
{
    public uint Tick {get; set;}
    public int horizontal;
    public int vertical;
}

[UpdateInGroup(typeof(GhostInputSystemGroup))]
[AlwaysSynchronizeSystem]
public class SampleCubeInput : SystemBase, PlayerInput.INiblerActions
{
    ClientSimulationSystemGroup m_ClientSimulationSystemGroup;
    private CubeInput _cubeInput;

    private PlayerInput _inputAction;
    protected override void OnCreate()
    {
        RequireSingletonForUpdate<NetworkIdComponent>();
        RequireSingletonForUpdate<EnableNetCubeGame>();
        m_ClientSimulationSystemGroup = World.GetExistingSystem<ClientSimulationSystemGroup>();

        _inputAction = new PlayerInput();
        _inputAction.Nibler.SetCallbacks(this);
    }

    protected override void OnStartRunning()
    {
        base.OnStartRunning();
        _inputAction.Enable();
    }

    protected override void OnStopRunning()
    {
        base.OnStopRunning();
        _inputAction.Disable();
    }

    protected override void OnUpdate()
    {
        var localInput = GetSingleton<CommandTargetComponent>().targetEntity;
        if (localInput == Entity.Null)
        {
            var localPlayerId = GetSingleton<NetworkIdComponent>().Value;
            var commandBuffer = new EntityCommandBuffer(Allocator.Temp);
            var commandTargetEntity = GetSingletonEntity<CommandTargetComponent>();
            Entities.WithAll<MovableCubeComponent>().WithNone<CubeInput>().ForEach((Entity ent, ref GhostOwnerComponent ghostOwner) =>
            {
                if (ghostOwner.NetworkId == localPlayerId)
                {
                    commandBuffer.AddBuffer<CubeInput>(ent);
                    commandBuffer.SetComponent(commandTargetEntity, new CommandTargetComponent {targetEntity = ent});
                }
            }).Run();
            commandBuffer.Playback(EntityManager);
            return;
        }
        _cubeInput.Tick = m_ClientSimulationSystemGroup.ServerTick;
    
        var inputBuffer = EntityManager.GetBuffer<CubeInput>(localInput);
        inputBuffer.AddCommandData(_cubeInput);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        _cubeInput.horizontal = (int) math.round(direction.x);
        _cubeInput.vertical = (int) math.round(direction.y);

    }
}
