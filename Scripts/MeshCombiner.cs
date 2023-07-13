using UnityEngine;

public class MeshCombiner : MonoBehaviour
{
    [SerializeField] private MeshCollider col;
    [SerializeField] private MeshFilter originalMesh;
    [SerializeField] private SaveMesh save;
    void Update()
    {
        //for debugging
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Combine();
            Debug.Log("combined meshes");
        }
    }
    public void Combine()
    {
        MeshFilter[] meshFilters = GetComponentsInChildren<MeshFilter>();

        CombineInstance[] combine = new CombineInstance[meshFilters.Length];

        for (int i = 0; i < meshFilters.Length; i++)
        {
            combine[i].mesh = meshFilters[i].sharedMesh;
            combine[i].transform = meshFilters[i].transform.localToWorldMatrix;
        }

        Mesh combinedMesh = new Mesh();
        combinedMesh.CombineMeshes(combine, true);

        originalMesh.sharedMesh = combinedMesh;
        col.sharedMesh = combinedMesh;

        save.UpdateMeshData(combinedMesh);

        Destroy(meshFilters[1].gameObject);
    }
}
