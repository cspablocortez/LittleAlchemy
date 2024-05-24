# LittleAlchemy


The set of C# scripts for Brandon's Little Alchemy Unity project.


## Thursday May 23

The GameObjects are now able to collide with each other and activate buttons by
tag upon collision. Following last lesson's work, we will implement the button 
activation feature below.

The new files are as follows:

1. `UIManager.cs` - a file to be attached to the `Canvas` element to disable all 
buttons at the start of the game.

2. `CollisionScript.cs` - in this collision demo, you will see the call 
to the `EnableButtonByTag()` method, which activates a UI element based on the 
given tag.

*Note:* The use of `UIManager.cs` requires that the buttons array 
field be initialized from the inspector before starting the game.

### UIManager.cs 

Here is a look at the new script `UIManager.cs`.

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

    public void EnableStarterButtons() 
    {
       for (int = 0; i < 4; i++) 
       {
          buttons[i].interactable = true;
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

### Collision Script

Below is `CollisionScript.cs`.

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour
{
    private UIManager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "foo" && collision.gameObject.tag == "bar" ||
            gameObject.tag == "bar" && collision.gameObject.tag == "foo")
        {
          uiManager.EnableButtonByTag("foobar");
        }
    }
}
```

Notice the `uiManager` reference, which allows us to access its `EnableButtonByTag()` method.

