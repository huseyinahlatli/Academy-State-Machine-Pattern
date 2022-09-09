using UnityEngine;

public abstract class AppleBaseState
{
    // EN ~ "Abstract" on each method means we need to define their functionality in classes that derive from appleBaseState
    // TR ~ Her yöntemdeki "abstract", işlevlerini AppleBaseState'den türetilen sınıflarda tanımlamamız gerektiği anlamına gelir.
    
    public abstract void EnterState(AppleStateManager apple);
    
    public abstract void UpdateState(AppleStateManager apple);
    
    public abstract void OnCollisionEnter(AppleStateManager apple, Collision collision);
}
