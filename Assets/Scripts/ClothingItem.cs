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

    
    public GameObject widthSlider;
    public GameObject heightSlider;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
        cg = GetComponent<CanvasGroup>();
        canvas = GetComponentInParent<Canvas>();
        resizer = FindObjectOfType<ClothingResizer>();

        
        widthSlider.SetActive(false);
        heightSlider.SetActive(false);
    }

    public void OnPointerClick(PointerEventData e)
    {
        
        widthSlider.SetActive(true);
        heightSlider.SetActive(true);

        resizer.SetCurrentItem(rect);
    }

    public void OnBeginDrag(PointerEventData e)
    {
        widthSlider.SetActive(true);
        heightSlider.SetActive(true);
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
