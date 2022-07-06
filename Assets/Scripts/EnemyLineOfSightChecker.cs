using UnityEngine;

public class EnemyLineOfSightChecker : MonoBehaviour
{
    public Enemy Enemy;
    public Transform Player;
    public float SpherecastRadius;
    public LayerMask LineOfSightLayers;

    public void Update()
    {
        Vector3 playerPosition = Player.position + Vector3.up * 1f;

        if (Physics.SphereCast(
            transform.position,
            SpherecastRadius,
            (playerPosition - transform.position).normalized,
            out RaycastHit hit,
            float.MaxValue,
            LineOfSightLayers
        ) && hit.collider != null && hit.collider.gameObject == Player.gameObject)
        {
            Enemy.OnGainSight();
        }
        else
        {
            Enemy.OnLoseSight();
        }
    }
}
