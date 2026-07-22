using UnityEngine;

public class ItemMovement : MonoBehaviour
{
    public float ItemSpeed = 5f;
    public float ItemDistance = 5f;
    private Transform target;

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    void Update()
    {
        if (!Target) return;

        Vector3 desiredPosition = target.Position - target.Forward * ItemDistance;
    }
}
