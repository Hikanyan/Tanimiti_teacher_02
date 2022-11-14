using UnityEngine;
public abstract class DeliveryBase<Argument> : MonoBehaviour
{
    public abstract void Initialize(Argument arg);
}