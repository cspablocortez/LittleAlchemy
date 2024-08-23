using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Button button in buttons)
        {
            button.interactable = false;
            Image buttonImage = button.GetComponent<Image>();
            buttonImage.color = new Color(buttonImage.color.r, buttonImage.color.g, buttonImage.color.b, 0f);
        }
        EnableStarterButtons();
    }

    // Update is called once per frame
    public void EnableAllButtons()
    {
        foreach (Button button in buttons)
        {
            button.interactable = true;
        }
    }

    public void EnableStarterButtons()
    {
         for (int i = 0; i < 4; i++)
        {
            buttons[i].interactable = true;
            Image buttonImage = buttons[i].GetComponent<Image>();
            buttonImage.color = new Color(buttonImage.color.r, buttonImage.color.g, buttonImage.color.b, 255f);
        }
    }

    public void EnableButtonByTag(string tag)
    {

        GameObject buttonObject = GameObject.FindGameObjectWithTag(tag); 
        if (buttonObject == null)
        {
            Debug.LogError("No button with tag " + tag + " found.");
        }
        else
        {
            buttonObject.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Image buttonImage = buttonObject.GetComponent<Image>();
            buttonImage.color = new Color(buttonImage.color.r, buttonImage.color.g, buttonImage.color.b, 255f);
        }
    }
}
