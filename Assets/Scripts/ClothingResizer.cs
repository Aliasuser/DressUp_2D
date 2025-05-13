using UnityEngine;
using UnityEngine.UI;

public class ClothingResizer : MonoBehaviour
{
    [Header("Assign your Width & Height sliders here")]
    public Slider widthSlider;
    public Slider heightSlider;

    private RectTransform currentItem;

    void Start()
    {
        widthSlider.onValueChanged.AddListener(OnWidthChanged);
        heightSlider.onValueChanged.AddListener(OnHeightChanged);
    }

   
    public void SetCurrentItem(RectTransform item)
    {
        currentItem = item;
        if (currentItem == null) return;

       
        widthSlider.minValue = 10;
        widthSlider.maxValue = 500;
        heightSlider.minValue = 10;
        heightSlider.maxValue = 500;

        //widthSlider.value = currentItem.sizeDelta.x;
        //heightSlider.value = currentItem.sizeDelta.y;
    }

    void OnWidthChanged(float newW)
    {
        if (currentItem == null) return;
        Vector2 s = currentItem.sizeDelta;
        s.x = newW;
        currentItem.sizeDelta = s;
    }

    void OnHeightChanged(float newH)
    {
        if (currentItem == null) return;
        Vector2 s = currentItem.sizeDelta;
        s.y = newH;
        currentItem.sizeDelta = s;
    }
}
