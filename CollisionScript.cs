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
        Debug.Log("STEP 2: CollisionScript running (and listening...)");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "foo" && collision.gameObject.tag == "bar" ||
            gameObject.tag == "bar" && collision.gameObject.tag == "foo")
        {

          Debug.Log("STEP 3: Call UIManager method EnableButtonByTag() after collision.");
          uiManager.EnableButtonByTag("foobar");
        }
    }
}