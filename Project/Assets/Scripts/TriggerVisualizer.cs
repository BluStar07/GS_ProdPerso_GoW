using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class TriggerVisualizer : MonoBehaviour
{
    [SerializeField] private Color gizmoColor = new Color(0f, 1f, 0f, 0.3f);
    private Color color;
    private void OnDrawGizmos()
    {
        color = gizmoColor;
        color.a = 1f;
        BoxCollider boxCollider = GetComponent<BoxCollider>();

        if (boxCollider != null && boxCollider.isTrigger)
        {
            Gizmos.color = gizmoColor;
            Gizmos.matrix = transform.localToWorldMatrix;
            Gizmos.DrawCube(boxCollider.center, boxCollider.size);

            Gizmos.color = color;
            Gizmos.DrawWireCube(boxCollider.center, boxCollider.size);
        }
    }
}
