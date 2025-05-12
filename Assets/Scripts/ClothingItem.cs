using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class ClothingItem : MonoBehaviour,
    IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler
{
    RectTransform rect;
    Canvas canvas;
    CanvasGroup cg;
    ClothingResizer resizer;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
        cg = GetComponent<CanvasGroup>();
        canvas = GetComponentInParent<Canvas>();
        resizer = FindObjectOfType<ClothingResizer>();
    }

  
    public void OnPointerClick(PointerEventData e)
    {
        resizer.SetCurrentItem(rect);
    }

    
    public void OnBeginDrag(PointerEventData e)
    {
        cg.alpha = 0.6f;
        cg.blocksRaycasts = false;
        resizer.SetCurrentItem(rect);
    }

    public void OnDrag(PointerEventData e)
    {
        rect.anchoredPosition += e.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData e)
    {
        cg.alpha = 1f;
        cg.blocksRaycasts = true;
    }
}
