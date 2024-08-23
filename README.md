# LittleAlchemy

The set of C# scripts for Brandon's Little Alchemy Unity project resumed on
Thursday, August 22, 2024.

# What's Next

- Dynamic dock that resizes according to number of element
- Background music via [Beepbox](https://beepbox.co)
- Sound effects for events, e.g., combinations, failed combinations, new game, starting over, etc.
- Button images [Piskel](https://www.piskelapp.com)

# Project Breakdown

All projects cover foundational CS concepts and then progressively increase in difficulty. 
For example, we started with a series of if-statements before moving onto dictionaries.

Within `UIManager` there are three methods:

- `Start()`
- `EnableAllButtons()`
- `EnableButtonByTag(string tag)`

We want the game to work like this:

When our two GameObjects collide, the  `OnCollisionEnter2D` method in our 
`CollisionScript.cs` will be executed. This method calls another method within 
our `CollisionScript.cs` called `GetCombinationTag()` which accepts two element
tags and produces a new one.

```cs
private void OnCollisionEnter2D(Collision2D collision)
{
    // Step 1: Store the new element Tag
    string combinationTag = GetCombinationTag(gameObject.tag, collision.gameObject.tag);

}
```

Here is the `GetCombinationTag()` method:

```cs
public string GetCombinationTag(string tag1, string tag2) {
        // TODO: Output the tag of the resulting object according to the table on Google Docs

        // 1. Display the first tag (verification code)

        Debug.Log(tag1);

        // 2. Display the second tag

        Debug.Log(tag2);

        // 3. Using CompareTag we'll produce the new one.

        if (tag1 == "fire" && tag2 == "air")
        {
            return "water vapor"; // fix capitalization to match actual tag name
        } else {
            return "no value found";
        }

    }
```

With a combination tag, now we can enable it by adding a new line to 
`OnCollisionEnter2D`:

```cs
 private void OnCollisionEnter2D(Collision2D collision)
    {
        string combinationTag = GetCombinationTag(gameObject.tag, collision.gameObject.tag);

        // Step 2: Enable the Button using our uiManager object.
        uiManager.EnableButtonByTag(combinationTag);

    }
```

Now let's take a look at how `EnableButtonByTag()` works.

# EnableButtonByTag()

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
