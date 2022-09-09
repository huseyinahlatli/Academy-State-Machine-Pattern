using UnityEngine;

public class AppleGrowingState : AppleBaseState
{
    private readonly Vector3 _startingAppleSize = new Vector3(0.1f, 0.1f, 0.1f);
    private readonly Vector3 _growAppleScalar = new Vector3(0.1f, 0.1f, 0.1f);
    
    public override void EnterState(AppleStateManager apple)
    {
        Debug.Log("GrowingState | EnterState");
        apple.transform.localScale = _startingAppleSize;
    }

    public override void UpdateState(AppleStateManager apple)
    {
        if (apple.transform.localScale.x < 1)
            apple.transform.localScale += _growAppleScalar * Time.deltaTime;
        else if (Random.value > 0.5f)
            apple.SwitchState(apple.WholeState);
        else
            apple.SwitchState(apple.SuperState);
    }

    public override void OnCollisionEnter(AppleStateManager apple, Collision collision)
    {

    }
}
