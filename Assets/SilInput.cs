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
                    ""name"": ""LeftStick"",
                    ""type"": ""Value"",
                    ""id"": ""030cb698-219e-454e-b37c-c8c4b8882548"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
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
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6de27950-189f-4b54-a250-77a96f2ee0ca"",
                    ""path"": ""<Keyboard>/d"",
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
                    ""path"": ""<Keyboard>/a"",
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
                    ""path"": ""<Keyboard>/w"",
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
                    ""path"": ""<Keyboard>/s"",
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
                    ""id"": ""62000f32-db9c-4204-a2c7-7dd103941990"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d881517-3dc9-4596-b2de-14dbba93157f"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""c1f2c9d3-aa0a-48f8-ad39-a4bc78229984"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c7a39bfa-78ac-46e1-824a-feef78b7b384"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""88974a5a-9b4c-4422-b832-5f81bf96030d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""96a97a80-885a-478a-8b94-5a82c8f63d70"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c17f60d6-1bd7-46a0-a080-035c00b7b309"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f0b9b0ce-458a-40c3-bcc6-6d5b1f12a10b"",
                    ""path"": ""<Mouse>/leftButton"",
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
                    ""path"": ""<Gamepad>/buttonEast"",
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
                    ""id"": ""9e73465a-5bbe-4a7e-8234-1a417134a2b3"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08b3bf65-4721-4140-9a24-e1ded5b63321"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
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
        m_Normal_LeftStick = m_Normal.FindAction("LeftStick", throwIfNotFound: true);
        m_Normal_Right = m_Normal.FindAction("Right", throwIfNotFound: true);
        m_Normal_Left = m_Normal.FindAction("Left", throwIfNotFound: true);
        m_Normal_Up = m_Normal.FindAction("Up", throwIfNotFound: true);
        m_Normal_Down = m_Normal.FindAction("Down", throwIfNotFound: true);
        m_Normal_Jump = m_Normal.FindAction("Jump", throwIfNotFound: true);
        m_Normal_Glide = m_Normal.FindAction("Glide", throwIfNotFound: true);
        m_Normal_Dash = m_Normal.FindAction("Dash", throwIfNotFound: true);
        m_Normal_RightStick = m_Normal.FindAction("RightStick", throwIfNotFound: true);
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
    private readonly InputAction m_Normal_LeftStick;
    private readonly InputAction m_Normal_Right;
    private readonly InputAction m_Normal_Left;
    private readonly InputAction m_Normal_Up;
    private readonly InputAction m_Normal_Down;
    private readonly InputAction m_Normal_Jump;
    private readonly InputAction m_Normal_Glide;
    private readonly InputAction m_Normal_Dash;
    private readonly InputAction m_Normal_RightStick;
    public struct NormalActions
    {
        private @SilInput m_Wrapper;
        public NormalActions(@SilInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftStick => m_Wrapper.m_Normal_LeftStick;
        public InputAction @Right => m_Wrapper.m_Normal_Right;
        public InputAction @Left => m_Wrapper.m_Normal_Left;
        public InputAction @Up => m_Wrapper.m_Normal_Up;
        public InputAction @Down => m_Wrapper.m_Normal_Down;
        public InputAction @Jump => m_Wrapper.m_Normal_Jump;
        public InputAction @Glide => m_Wrapper.m_Normal_Glide;
        public InputAction @Dash => m_Wrapper.m_Normal_Dash;
        public InputAction @RightStick => m_Wrapper.m_Normal_RightStick;
        public InputActionMap Get() { return m_Wrapper.m_Normal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NormalActions set) { return set.Get(); }
        public void SetCallbacks(INormalActions instance)
        {
            if (m_Wrapper.m_NormalActionsCallbackInterface != null)
            {
                @LeftStick.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnLeftStick;
                @LeftStick.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnLeftStick;
                @LeftStick.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnLeftStick;
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
            }
            m_Wrapper.m_NormalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftStick.started += instance.OnLeftStick;
                @LeftStick.performed += instance.OnLeftStick;
                @LeftStick.canceled += instance.OnLeftStick;
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
            }
        }
    }
    public NormalActions @Normal => new NormalActions(this);
    public interface INormalActions
    {
        void OnLeftStick(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnGlide(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnRightStick(InputAction.CallbackContext context);
    }
}
