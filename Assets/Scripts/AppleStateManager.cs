using UnityEngine;

public class AppleStateManager : MonoBehaviour
{
    // _currentState holds a reference to the active state in a state machine.
    // State machines can only be in one state at a time
    
    private AppleBaseState currentState;
    public AppleChewedState ChewedState = new AppleChewedState();     
    public AppleGrowingState GrowingState = new AppleGrowingState();   
    public AppleRottenState RottenState = new AppleRottenState();     
    public AppleWholeState WholeState = new AppleWholeState();        
    public AppleSuperState SuperState = new AppleSuperState();        

    private void Start()
    {
        currentState = GrowingState; 
        currentState.EnterState(this);
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(AppleBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(this, collision);
    }
}
