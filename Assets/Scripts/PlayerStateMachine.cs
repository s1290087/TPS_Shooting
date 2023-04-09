using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    [SerializeField] public Animator playerAnimator;
    [SerializeField] public InputReader input;
    [SerializeField] public float movementSpeed;
    private void Start() 
    {
        SwitchState(new PlayerWalkAroundState(this));    
    }
}
