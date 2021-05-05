// GENERATED AUTOMATICALLY FROM 'Assets/NetCube/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Nibler"",
            ""id"": ""9b75a22c-9687-43b8-a368-088c95db4bbb"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""80f9fa7f-0909-475f-ba9b-f5c47d8a7e5f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""72d86287-09e0-4333-8093-9f7863c7e88d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6612a5d7-62c5-4b8f-aec3-f0ceb73a36a1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse;Oculus"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7ffb0e8c-78fb-414a-90d6-9ae577c25e77"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse;Oculus"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""01635f48-1fa8-4864-8ad4-7c5b0a03662c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse;Oculus"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c22ae108-2e13-4f9a-b30a-a56305a9da0b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse;Oculus"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardAndMouse"",
            ""bindingGroup"": ""KeyboardAndMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Oculus"",
            ""bindingGroup"": ""Oculus"",
            ""devices"": [
                {
                    ""devicePath"": ""<OculusTouchController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<OculusHMD>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Nibler
        m_Nibler = asset.FindActionMap("Nibler", throwIfNotFound: true);
        m_Nibler_Move = m_Nibler.FindAction("Move", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Nibler
    private readonly InputActionMap m_Nibler;
    private INiblerActions m_NiblerActionsCallbackInterface;
    private readonly InputAction m_Nibler_Move;
    public struct NiblerActions
    {
        private @PlayerInput m_Wrapper;
        public NiblerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Nibler_Move;
        public InputActionMap Get() { return m_Wrapper.m_Nibler; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NiblerActions set) { return set.Get(); }
        public void SetCallbacks(INiblerActions instance)
        {
            if (m_Wrapper.m_NiblerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_NiblerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_NiblerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_NiblerActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_NiblerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public NiblerActions @Nibler => new NiblerActions(this);
    private int m_KeyboardAndMouseSchemeIndex = -1;
    public InputControlScheme KeyboardAndMouseScheme
    {
        get
        {
            if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardAndMouse");
            return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
        }
    }
    private int m_OculusSchemeIndex = -1;
    public InputControlScheme OculusScheme
    {
        get
        {
            if (m_OculusSchemeIndex == -1) m_OculusSchemeIndex = asset.FindControlSchemeIndex("Oculus");
            return asset.controlSchemes[m_OculusSchemeIndex];
        }
    }
    public interface INiblerActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
