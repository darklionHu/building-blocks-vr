using UnityEngine;

[CreateAssetMenu]
public class ObjectData : ScriptableObject
{
    public Vector3[] vertices;
    public int[] triangles;
    public Vector3[] normals;
    public Vector2[] uv;
}
