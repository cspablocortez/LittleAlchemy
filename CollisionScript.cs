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
          // 1.

          string combinationTag = ResultingElementTag(gameObject.tag, collision.gameObject.tag);
          uiManager.EnableButtonByTag(combinationTag);
        }
    }

    public string ResultingElementTag(string tag1, string tag2) {
        // 2. Output the tag of the resulting object according to the table on Google Docs
    }
}