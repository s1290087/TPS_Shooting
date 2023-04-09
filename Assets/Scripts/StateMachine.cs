using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private State currentState;
    
    private void Update()
    {
        currentState?.Tick(Time.deltaTime);
    }

    // 状態の変化 
    public void SwitchState(State newState)
    {
        currentState?.Exit();
        this.currentState = newState;
        currentState.Enter();
    }
}
