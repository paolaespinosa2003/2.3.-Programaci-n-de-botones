using UnityEngine;
using UnityEngine.EventSystems;

public class DragSprite : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
}
