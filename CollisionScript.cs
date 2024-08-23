using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour
{
    private UIManager uiManager;
    private Dictionary<(string, string), string> collisionResults;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        Debug.Log(uiManager);

        collisionResults = new Dictionary<(string, string), string>
        {
            { ("fire", "water"), "water vapor" },
            { ("fire", "earth"), "lava" },
            { ("water", "earth"), "mud" },
            { ("lava", "water"), "rock" },
            { ("mud", "rock"), "clay" },
            { ("air", "rock"), "sand" },
            { ("fire", "air"), "smoke" },
            { ("water vapor", "water vapor"), "cloud" },
            { ("fire", "clay"), "brick" },
            { ("fire", "smoke"), "electric" },
            { ("electric", "cloud"), "thunder cloud" },
        };
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag1 = gameObject.tag;
        string tag2 = collision.gameObject.tag;

        if (collisionResults.TryGetValue((tag1, tag2), out string result) ||
            collisionResults.TryGetValue((tag2, tag1), out result))
        {
            Debug.Log(result);
            uiManager.EnableButtonByTag(result);
            Destroy(this.gameObject);
        }
    }

}
