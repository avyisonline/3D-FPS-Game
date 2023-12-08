using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent (typeof(MeshCollider))]

public class MeshGenerator : MonoBehaviour
{

    Vector3[] vertices;
    int[] triangles;
    public Mesh mesh;

    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        CreateShape();
        UpdateMesh();

        GetComponent<MeshCollider>().sharedMesh = mesh;
        GetComponent<MeshCollider>().convex = true;
    }

    void CreateShape()
    {
        vertices = new Vector3[]
        {
            new Vector3 (0.0f, 0.0f, 0.0f), // 0
            new Vector3 (1.0f, 0.0f, 0.0f), // 1
            new Vector3 (0.0f, 0.0f, 1.0f), // 2
            new Vector3 (1.0f, 0.0f, 1.0f), // 3
            new Vector3 (0.5f, 1.0f, 0.5f), // 4
            new Vector3 (0.5f, -1.0f, 0.5f), // 5

        };

        triangles = new int[]
        {
            0, 1, 2,
            3, 2, 1,
            
            4, 1, 0,
            4, 3, 1,
            2, 3, 4,
            0, 2, 4,

            5, 1, 0,
            5, 3, 1,
            2, 3, 5,
            0, 2, 5,
        };
    }

    void UpdateMesh()
    {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;

    }
}
