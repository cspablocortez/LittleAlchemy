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