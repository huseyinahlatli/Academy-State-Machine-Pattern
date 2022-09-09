using UnityEngine;

public class AppleWholeState : AppleBaseState
{
    private float _rottenCountDown = 10.0f;
    
    public override void EnterState(AppleStateManager apple)
    {
        Debug.Log("WholeState | EnterState");
        var rigidbody = apple.GetComponent<Rigidbody>();
        if (rigidbody.useGravity != true)
            rigidbody.useGravity = true;
    }

    public override void UpdateState(AppleStateManager apple)
    {
        if (_rottenCountDown >= 0)
            _rottenCountDown -= Time.deltaTime;
        else
            apple.SwitchState(apple.RottenState);
    }

    public override void OnCollisionEnter(AppleStateManager apple, Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.CompareTag("Player"))
        {
            // other.GetComponent<PlayerController>().addHealth();
            Debug.Log("The character's health increases.");
            apple.SwitchState(apple.ChewedState);
        }
    }
}
