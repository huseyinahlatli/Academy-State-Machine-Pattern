using UnityEngine;

public class AppleRottenState : AppleBaseState
{
    private readonly Vector3 _decreaseAppleScalar = new Vector3(0.1f, 0.1f, 0.1f);
    
    public override void EnterState(AppleStateManager apple)
    {
        Debug.Log("RottenState | EnterState");
    }

    public override void UpdateState(AppleStateManager apple)
    {
        if(apple.transform.localScale.x >= 0.5f)
            apple.transform.localScale -= _decreaseAppleScalar * Time.deltaTime;
    }

    public override void OnCollisionEnter(AppleStateManager apple, Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.CompareTag("Player"))
        {
            // other.GetComponent<PlayerController>().detractHealth();
            Debug.Log("Character's health decreased!");
            apple.SwitchState(apple.ChewedState);
        }
    }
}
