using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    [SerializeField] private Transform parent;
    [SerializeField] private Transform spawnLocation;
    [SerializeField] private GameObject cube;
    void Update()
    {
        //for debugging
        if(Input.GetKeyDown(KeyCode.F2))
        {
            Spawn();
            Debug.Log("spawned");
        }
    }
    public void Spawn()
    {
        //if the GM object has more than 1 object as its children it means that a spawned cube already exists
        if (parent.childCount == 1)
        {
            GameObject _cube = Instantiate(cube, spawnLocation.position, Quaternion.identity, parent);
        }
    }
}
