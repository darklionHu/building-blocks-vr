using UnityEngine;

public class SaveMesh : MonoBehaviour
{
    [SerializeField] private ObjectData data;
    [SerializeField] private MeshFilter meshFilter;
    private void Start()
    {
        LoadMeshData();
    }
    public void UpdateMeshData(Mesh mesh)
    {
        data.triangles = mesh.triangles;
        data.vertices = mesh.vertices;
        data.normals = mesh.normals;
        data.uv = mesh.uv;
    }
    public void LoadMeshData()
    {
        Mesh mesh = new Mesh();

        mesh.SetVertices(data.vertices);
        mesh.SetTriangles(data.triangles, 0);
        mesh.SetNormals(data.normals);
        mesh.SetUVs(0,data.uv);

        /*mesh.triangles = data.triangles;
        mesh.vertices = data.vertices;
        mesh.normals = data.normals;
        mesh.uv = data.uv;*/

        meshFilter.sharedMesh = mesh;
    }
}
