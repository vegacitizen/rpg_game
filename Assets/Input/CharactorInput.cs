// GENERATED AUTOMATICALLY FROM 'Assets/Input/CharactorInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CharactorInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CharactorInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CharactorInput"",
    ""maps"": [
        {
            ""name"": ""WarriorControl"",
            ""id"": ""0a056d42-3cbc-41b7-8b26-27fbfe239a99"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""342798c2-ab9a-40d5-98d9-7a517a8cb30d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""a4d0730d-1012-48ff-8f7c-b8dee028d500"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5207ceef-9cad-49a9-afd6-1de11d4947f3"",
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
                    ""id"": ""02581dfb-75c8-498d-9bde-5018913dc1a2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2de20f4c-456e-4254-946d-65f179e1dc3b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f29bb48f-1939-49b8-865b-53e1c2a97213"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5f78d5ba-be5c-42fa-8138-c3c16ea8cf60"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5981ac73-801e-4142-afad-27a68818aa73"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // WarriorControl
        m_WarriorControl = asset.FindActionMap("WarriorControl", throwIfNotFound: true);
        m_WarriorControl_Move = m_WarriorControl.FindAction("Move", throwIfNotFound: true);
        m_WarriorControl_Attack = m_WarriorControl.FindAction("Attack", throwIfNotFound: true);
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

    // WarriorControl
    private readonly InputActionMap m_WarriorControl;
    private IWarriorControlActions m_WarriorControlActionsCallbackInterface;
    private readonly InputAction m_WarriorControl_Move;
    private readonly InputAction m_WarriorControl_Attack;
    public struct WarriorControlActions
    {
        private @CharactorInput m_Wrapper;
        public WarriorControlActions(@CharactorInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_WarriorControl_Move;
        public InputAction @Attack => m_Wrapper.m_WarriorControl_Attack;
        public InputActionMap Get() { return m_Wrapper.m_WarriorControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WarriorControlActions set) { return set.Get(); }
        public void SetCallbacks(IWarriorControlActions instance)
        {
            if (m_Wrapper.m_WarriorControlActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_WarriorControlActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_WarriorControlActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_WarriorControlActionsCallbackInterface.OnMove;
                @Attack.started -= m_Wrapper.m_WarriorControlActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_WarriorControlActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_WarriorControlActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_WarriorControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public WarriorControlActions @WarriorControl => new WarriorControlActions(this);
    public interface IWarriorControlActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
}
