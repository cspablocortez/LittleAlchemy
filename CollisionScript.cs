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
        // 1. Store the new element Tag
        string combinationTag = GetCombinationTag(gameObject.tag, collision.gameObject.tag);

        // 2. Enable the Button using our uiManager object.
        uiManager.EnableButtonByTag(combinationTag);

    }

    public string GetCombinationTag(string tag1, string tag2) {
        // TODO: Output the tag of the resulting object according to the table on Google Docs

        // 1. Display the first tag (verification code)

        Debug.Log(tag1);

        // 2. Display the second tag

        Debug.Log(tag2);

        // 3. Using CompareTag we'll produce the new one.

        if (tag1.CompareTag("fire") && tag2.CompareTag("air"))
        {
            return "water vapor"; // fix capitalization to match actual tag name
        } else {
            return "no value found";
        }

    }
}