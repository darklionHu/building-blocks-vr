using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float minGripForce;

    private Transform rightHand;
    [SerializeField] private Vector3 gridSize = new Vector3(1,1,1);
    private void Start()
    {
        rightHand = GameObject.FindGameObjectWithTag("RightHand").transform;
    }
    void Update()
    {
        Snap();

        if(InputsManager.gripForce < minGripForce)
        {
            StopFollowing();
        }
    }
    
    void Snap()
    {
        transform.position = new Vector3(
            Mathf.Round(rightHand.position.x / gridSize.x) * gridSize.x,
            Mathf.Round(rightHand.position.y / gridSize.y) * gridSize.y,
            Mathf.Round(rightHand.position.z / gridSize.z) * gridSize.z
        );
    }

    void StopFollowing()
    {
        transform.parent.GetComponent<MeshCombiner>().Combine();
        this.enabled = false;
    }
}
