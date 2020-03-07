using UnityEngine;
using System.Linq;

public class InvertMesh : MonoBehaviour
{    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.triangles = mesh.triangles.Reverse().ToArray();
    }
}
