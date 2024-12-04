using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class TriggerVisualizer : MonoBehaviour
{
    [SerializeField] bool _visible = true;

    [SerializeField] private Color gizmoColor = new Color(0f, 1f, 0f, 0.3f);
    private Color color;
    private void OnDrawGizmos()
    {
        color = gizmoColor;
        color.a = 1f;
        BoxCollider boxCollider = GetComponent<BoxCollider>();

        if (boxCollider != null && _visible)
        {
            Gizmos.color = gizmoColor;
            Gizmos.matrix = transform.localToWorldMatrix;
            Gizmos.DrawCube(boxCollider.center, boxCollider.size);

            Gizmos.color = color;
            Gizmos.DrawWireCube(boxCollider.center, boxCollider.size);
        }
    }
}
