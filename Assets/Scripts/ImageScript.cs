using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    
    public GameObject imageField;
    public Sprite[] soriteArray;
    public GameObject widthSlider;
    public GameObject heightSlider;


    public void ChangeWidth()
    {
        float currentWidth = widthSlider.GetComponent<Slider>().value;
        Vector3 currentScale = imageField.transform.localScale;
        imageField.transform.localScale = new Vector3(currentWidth, currentScale.y, currentScale.z);
    }

    public void ChangeHeight()
    {
        float currentHeight = heightSlider.GetComponent<Slider>().value;
        Vector3 currentScale = imageField.transform.localScale;
        imageField.transform.localScale = new Vector3(currentScale.x, currentHeight, currentScale.z);
    }

    public void Dropdown (int index)
    {
        if(index == 0) 
            imageField.GetComponent<Image>().sprite = soriteArray[0];

        else if (index == 1)
            imageField.GetComponent<Image>().sprite = soriteArray[1];

        else if (index == 2)
            imageField.GetComponent<Image>().sprite = soriteArray[2];
        else if(index == 3)
            imageField.GetComponent<Image>().sprite = soriteArray[3];
        else if(index == 4)
            imageField.GetComponent<Image>().sprite = soriteArray[4];
        else if (index == 5)
            imageField.GetComponent<Image>().sprite = soriteArray[5];
        else if (index == 6)
            imageField.GetComponent<Image>().sprite = soriteArray[6];
    }

    
}
