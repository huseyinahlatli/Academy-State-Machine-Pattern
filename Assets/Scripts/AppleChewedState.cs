using UnityEngine;

public class AppleChewedState : AppleBaseState 
{
    private float _destroyCountDown = 5.0f;
     
    public override void EnterState(AppleStateManager apple)
    {
        Debug.Log("ChewedState | EnterState");
        Debug.Log("The apple was chewed!");
    }

    public override void UpdateState(AppleStateManager apple)
    {
        if (_destroyCountDown > 0)
            _destroyCountDown -= Time.deltaTime;
        else
        {
            Debug.Log("The apple is destroyed!");
            Object.Destroy(apple.gameObject);
        }
    }

    public override void OnCollisionEnter(AppleStateManager apple, Collision collision)
    {
        
    }
}
