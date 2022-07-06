using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyMovement Movement;
    public EnemyLineOfSightChecker LineOfSightChecker;

    private MeshFilter MeshFilter;
    private Mesh Mesh;
    private Color[] Colors;

    private bool HasLineOfSight;

    private void Awake()
    {
        MeshFilter = GetComponent<MeshFilter>();
        Mesh = MeshFilter.sharedMesh;
        Colors = Mesh.colors;
    }

    public void OnGainSight()
    {
        if (!HasLineOfSight)
        {
            ChangeColor(Color.green);
            HasLineOfSight = true;
        }
    }

    public void OnLoseSight()
    {
        if (HasLineOfSight)
        {
            ChangeColor(Color.red);
            HasLineOfSight = false;
        }
        
    }

    private void ChangeColor(Color Color)
    {
        for (int i = 0; i < Colors.Length; i++)
        {
            Colors[i] = Color;
        }
        Mesh.colors = Colors;
    }
}
