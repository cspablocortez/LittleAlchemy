using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button[] buttons; // Assign all the buttons in the inspector

    private void Start()
    {
        // Make all buttons non-interactable at the start
        foreach (Button button in buttons)
        {
            button.interactable = false;
        }
    }

    // Method to enable all buttons
    public void EnableAllButtons()
    {
        foreach (Button button in buttons)
        {
            button.interactable = true;
        }
    }

    // Method to enable button by tag
    public void EnableButtonByTag(string tag) 
    {
          // Find and activate the button with the combined tag
            GameObject buttonObject = GameObject.FindGameObjectWithTag(tag);
            if (buttonObject != null)
            {
                buttonObject.GetComponent<UnityEngine.UI.Button>().interactable = true;
            }
    }

}
