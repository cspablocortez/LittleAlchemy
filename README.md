# LittleAlchemy


The set of C# scripts for Brandon's Little Alchemy Unity project.

This repository includes old files from previous classes and the new 
implementation from the end of class on Thursday 2 May.

### Thursday May 23

The GameObjects are now able to collide with each other and activate buttons by
tag upon collision. Following last lesson's work, we will implement the button 
activation feature below.

The new files are as follows:

1. `UIManager.cs` - a file to be attached to the `Canvas` element to disable all 
buttons at the start of the game.

2. `CollisionScript.cs` - in this demo of the collision, you will see the call 
to the `EnableButtonByTag()` method, which activates a UI element based on the 
given tag.

*Note:* The use of `UIManager.cs` requires that the buttons array 
field be initialized from the inspector before starting the game.

Here is a look at the new script `UIManager.cs`

```cs
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
```

This approach requires that all buttons we want to activate are held within the `buttons` 
field of the `UIMangaer.cs` script.

The `EnableButtonByTag()` method provides a `tag` string parameter to find an object by
its tag and set its `interactable` property to `true`.





### Thursday 16 May

1. We will create a UI Manager script 

2. Follow steps listed in `UIManager.cs`

3. Refactor previous scripts and remove unused or unnecessary code.