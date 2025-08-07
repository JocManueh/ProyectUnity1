
using UnityEngine;
using UnityEngine.EventSystems;

public class PosicionMouse : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        RectTransform rectTransform = GetComponent<RectTransform>();

        Vector2 localPoint;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, eventData.position, eventData.pressEventCamera, out localPoint))
        {
            Debug.Log("Posición del mouse dentro del panel (local): " + localPoint);
        }
    }
}