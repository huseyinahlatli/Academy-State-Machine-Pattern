using UnityEngine;

public class AppleSuperState : AppleBaseState
{
    public override void EnterState(AppleStateManager apple)
    {
        Debug.Log("SuperState | EnterState");
        apple.GetComponent<Rigidbody>().useGravity = true;
    }

    public override void UpdateState(AppleStateManager apple)
    {
        
    }

    public override void OnCollisionEnter(AppleStateManager apple, Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.CompareTag("Player"))
        {
            // other.GetComponent<PlayerController>().addHealth();
            // other.GetComponent<PlayerController>().addExtraHealth();
            Debug.Log("The character's health increases.");
            Debug.Log("The character's health super increases.");
            apple.SwitchState(apple.ChewedState);
        }
    }
}
