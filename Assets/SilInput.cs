// GENERATED AUTOMATICALLY FROM 'Assets/SilInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @SilInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @SilInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SilInput"",
    ""maps"": [
        {
            ""name"": ""Normal"",
            ""id"": ""b43f5e45-e197-421a-8aaa-00b2225bef39"",
            ""actions"": [
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""e5afd90b-fe1e-4689-9fcd-ebb1555aa18e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""b1de9c0f-7a7e-4e10-948b-8c4be03d7383"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""440d9fc5-c9c7-4c2d-bfc3-f8a5a156dc4d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""45b0b42c-25c6-45be-a99b-535a65827c22"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""e43cf3a2-4927-439a-96fb-e4c18d07c3cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Glide"",
                    ""type"": ""Button"",
                    ""id"": ""9699e77e-c151-4ab4-bd3f-57a9a2dd2932"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""e7bb25fc-d523-4ef0-ba4b-28d988386f26"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightStick"",
                    ""type"": ""Value"",
                    ""id"": ""073b6301-14b2-4f53-9550-29b76205999f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Tether"",
                    ""type"": ""Button"",
                    ""id"": ""1ba7b89d-b9c5-45eb-b17e-1cf1424062e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""284e9449-81e8-4748-b982-5e75bb161d72"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6de27950-189f-4b54-a250-77a96f2ee0ca"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e291457-7fa1-4384-b313-32814b596e24"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d65741f5-dffc-44bc-af01-a0925e992b60"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e719592-2cb6-40a3-8762-d9b9a2aab4d6"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d1e5511-f8f8-44af-8610-994d24251f72"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""159b1aec-43bc-4704-bd3e-f18fe666c492"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2de3b115-a53d-460c-933e-9547138b9455"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9323811a-f296-45bf-b9e5-ea9398abb6e1"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a89cad95-c508-4c2b-838f-291c2e35bfdb"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a9bde72-9228-4b66-9642-2a5ca7e40b89"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ec3a4f5-bf8f-4a35-8245-6236f65ee45d"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff2c91a7-1edd-4239-bf7c-0a2c3d376ecf"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1612ba75-97d2-42c8-a512-aed2f6e98677"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa4dbe09-ffb3-45c7-adce-9b9e4c8b24a8"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08f7a054-9d2c-4447-90dc-1753eb33be82"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Glide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53a81e1f-d196-4a53-aa56-547e1c921186"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Glide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4776e4bd-07c3-4d9a-b4e8-6cd292b84551"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Glide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0b9b0ce-458a-40c3-bcc6-6d5b1f12a10b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e9d4fe7-76b7-4086-88d9-41eed8795a8f"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8281cf8-a578-4e7a-acdc-586959b96444"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1d45d54-3757-45a0-a139-513cc0228609"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tether"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9bb165e-06bd-4a8a-8305-9dbe005ff948"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tether"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fda1f681-3cb0-465a-a10f-6cc4fd133f56"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d09d8381-8d56-43e8-a030-4debe10db73e"",
                    ""path"": ""<Keyboard>/a"",
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
        // Normal
        m_Normal = asset.FindActionMap("Normal", throwIfNotFound: true);
        m_Normal_Right = m_Normal.FindAction("Right", throwIfNotFound: true);
        m_Normal_Left = m_Normal.FindAction("Left", throwIfNotFound: true);
        m_Normal_Up = m_Normal.FindAction("Up", throwIfNotFound: true);
        m_Normal_Down = m_Normal.FindAction("Down", throwIfNotFound: true);
        m_Normal_Jump = m_Normal.FindAction("Jump", throwIfNotFound: true);
        m_Normal_Glide = m_Normal.FindAction("Glide", throwIfNotFound: true);
        m_Normal_Dash = m_Normal.FindAction("Dash", throwIfNotFound: true);
        m_Normal_RightStick = m_Normal.FindAction("RightStick", throwIfNotFound: true);
        m_Normal_Tether = m_Normal.FindAction("Tether", throwIfNotFound: true);
        m_Normal_Attack = m_Normal.FindAction("Attack", throwIfNotFound: true);
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

    // Normal
    private readonly InputActionMap m_Normal;
    private INormalActions m_NormalActionsCallbackInterface;
    private readonly InputAction m_Normal_Right;
    private readonly InputAction m_Normal_Left;
    private readonly InputAction m_Normal_Up;
    private readonly InputAction m_Normal_Down;
    private readonly InputAction m_Normal_Jump;
    private readonly InputAction m_Normal_Glide;
    private readonly InputAction m_Normal_Dash;
    private readonly InputAction m_Normal_RightStick;
    private readonly InputAction m_Normal_Tether;
    private readonly InputAction m_Normal_Attack;
    public struct NormalActions
    {
        private @SilInput m_Wrapper;
        public NormalActions(@SilInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Right => m_Wrapper.m_Normal_Right;
        public InputAction @Left => m_Wrapper.m_Normal_Left;
        public InputAction @Up => m_Wrapper.m_Normal_Up;
        public InputAction @Down => m_Wrapper.m_Normal_Down;
        public InputAction @Jump => m_Wrapper.m_Normal_Jump;
        public InputAction @Glide => m_Wrapper.m_Normal_Glide;
        public InputAction @Dash => m_Wrapper.m_Normal_Dash;
        public InputAction @RightStick => m_Wrapper.m_Normal_RightStick;
        public InputAction @Tether => m_Wrapper.m_Normal_Tether;
        public InputAction @Attack => m_Wrapper.m_Normal_Attack;
        public InputActionMap Get() { return m_Wrapper.m_Normal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NormalActions set) { return set.Get(); }
        public void SetCallbacks(INormalActions instance)
        {
            if (m_Wrapper.m_NormalActionsCallbackInterface != null)
            {
                @Right.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnRight;
                @Left.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnLeft;
                @Up.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnDown;
                @Jump.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @Glide.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnGlide;
                @Glide.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnGlide;
                @Glide.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnGlide;
                @Dash.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnDash;
                @RightStick.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnRightStick;
                @RightStick.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnRightStick;
                @RightStick.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnRightStick;
                @Tether.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnTether;
                @Tether.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnTether;
                @Tether.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnTether;
                @Attack.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_NormalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Glide.started += instance.OnGlide;
                @Glide.performed += instance.OnGlide;
                @Glide.canceled += instance.OnGlide;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @RightStick.started += instance.OnRightStick;
                @RightStick.performed += instance.OnRightStick;
                @RightStick.canceled += instance.OnRightStick;
                @Tether.started += instance.OnTether;
                @Tether.performed += instance.OnTether;
                @Tether.canceled += instance.OnTether;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public NormalActions @Normal => new NormalActions(this);
    public interface INormalActions
    {
        void OnRight(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnGlide(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnRightStick(InputAction.CallbackContext context);
        void OnTether(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
}
