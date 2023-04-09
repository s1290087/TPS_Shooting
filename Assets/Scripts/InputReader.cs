using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour,Controls.IPlayerActions
{

    public Vector2 MovmentValue {private set; get; }
    private Controls controls;
    private void Start()
    {
        controls = new Controls();
        controls.Player.SetCallbacks(this);

        controls.Player.Enable();
    }
    public void OnAim(InputAction.CallbackContext context)
    {
        if(!context.performed){ return; }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        MovmentValue = context.ReadValue<Vector2>();
        Debug.Log(MovmentValue);
    }

    public void OnScope(InputAction.CallbackContext context)
    {
        if(!context.performed){ return; }
    }
}
