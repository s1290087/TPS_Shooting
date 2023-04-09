using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkAroundState : PlayerBaseState
{
    private readonly int forwardHash = Animator.StringToHash("forward");
    private readonly int rightHash = Animator.StringToHash("right");

    public PlayerWalkAroundState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.playerAnimator.SetFloat(forwardHash,0f);
        stateMachine.playerAnimator.SetFloat(rightHash,0f);
    }
    public override void Tick(float deltaTime)
    {
        Move(deltaTime);
    }
    public override void Exit()
    {
    }

    private void Move(float deltaTime)
    {
        float animationDampTime = 0.1f;

        Vector2 InputMovment = stateMachine.input.MovmentValue;
        
        float value;

        if(InputMovment.x == 0f)
        {
            stateMachine.playerAnimator.SetFloat(forwardHash,0f,animationDampTime,deltaTime);
        }
        else
        {
            value = InputMovment.x > 0 ? 1f : -1f;
            stateMachine.playerAnimator.SetFloat(forwardHash,value,animationDampTime,deltaTime);
        }

        if(InputMovment.y == 0f)
        {
            stateMachine.playerAnimator.SetFloat(rightHash,0f,animationDampTime,deltaTime);
        }
        else
        {
            value = InputMovment.y > 0 ? 1f : -1f;
            stateMachine.playerAnimator.SetFloat(rightHash,value,animationDampTime,deltaTime); 
        }

    }

}
