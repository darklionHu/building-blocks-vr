using UnityEngine;
using UnityEngine.InputSystem;

public class TraySystem : MonoBehaviour
{
    private bool canSpawnCube;

    [SerializeField] private float minGripForce;
    [SerializeField] private SpawnCube cubeSpawner;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "RightHand")
        {
            canSpawnCube = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "RightHand")
        {
            canSpawnCube = false;
        }
    }

    void Update()
    {
        if(InputsManager.gripForce > minGripForce && canSpawnCube)
        {
            cubeSpawner.Spawn();
        }
    }
}
