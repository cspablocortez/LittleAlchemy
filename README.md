# LittleAlchemy

The set of C# scripts for Brandon's Little Alchemy Unity project resumed on
Thursday, June 20, 2024.

# Step 1

We began by verifying that the `Canvas` element had a `UIManager.cs` script,
with its Button[] array field variable initialized to the buttons held by the 
scrollbar object.

# Step 2

Within `UIManager` there are three methods:

- `Start()`
- `EnableAllButtons()`
- `EnableButtonByTag(string tag)`

# Debugging EnableButtonByTag()

```cs
 // Method to enable button by tag
    public void EnableButtonByTag(string tag) 
    {
          // Find and activate the button with the combined tag
            GameObject buttonObject = GameObject.FindGameObjectWithTag(tag); // this replaces one of the existing functions in ButtonActivation.cs
            if (buttonObject != null)
            {
                buttonObject.GetComponent<UnityEngine.UI.Button>().interactable = true;
            }
    }
```

# CollisionScript.cs

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