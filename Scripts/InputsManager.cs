using UnityEngine;
using UnityEngine.InputSystem;

public class InputsManager : MonoBehaviour
{
    public static float gripForce;
    [SerializeField] private InputActionProperty pickUp;

    void Update()
    {
        gripForce = pickUp.action.ReadValue<float>();
    }
}
