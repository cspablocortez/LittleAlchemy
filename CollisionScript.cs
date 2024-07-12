using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour
{
    private UIManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        Debug.Log(uiManager);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter in CollisionScript.cs has activated");

        if (gameObject.tag == "fire" && collision.gameObject.tag == "water" ||
            gameObject.tag == "water" && collision.gameObject.tag == "fire")
        {
            uiManager.EnableButtonByTag("water vapor");
            Destroy(this.gameObject);
        }


        if (gameObject.tag == "fire" && collision.gameObject.tag == "earth" ||
        gameObject.tag == "earth" && collision.gameObject.tag == "fire")
        {
            uiManager.EnableButtonByTag("lava");
            Destroy(this.gameObject);
        }


        if (gameObject.tag == "water" && collision.gameObject.tag == "earth" ||
      gameObject.tag == "earth" && collision.gameObject.tag == "water")
        {
            uiManager.EnableButtonByTag("mud");
            Destroy(this.gameObject);
        }


        if (gameObject.tag == "lava" && collision.gameObject.tag == "water" ||
    gameObject.tag == "water" && collision.gameObject.tag == "lava")
        {    
            uiManager.EnableButtonByTag("rock");
            Destroy(this.gameObject);
        }


        if (gameObject.tag == "mud" && collision.gameObject.tag == "rock" ||
gameObject.tag == "rock" && collision.gameObject.tag == "mud")
        {  
            uiManager.EnableButtonByTag("clay");
            Destroy(this.gameObject);
        }


        if (gameObject.tag == "air" && collision.gameObject.tag == "rock" ||
gameObject.tag == "rock" && collision.gameObject.tag == "air")
        {
            uiManager.EnableButtonByTag("sand");
            Destroy(this.gameObject);
        }


        if (gameObject.tag == "fire" && collision.gameObject.tag == "air" ||
gameObject.tag == "air" && collision.gameObject.tag == "fire")
        {
            uiManager.EnableButtonByTag("smoke");
            Destroy(this.gameObject);
        }


        if (gameObject.tag == "water vapor" && collision.gameObject.tag == "water vapor")
        {
            uiManager.EnableButtonByTag("cloud");
            Destroy(this.gameObject);
        }


        if (gameObject.tag == "fire" && collision.gameObject.tag == "clay" ||
gameObject.tag == "clay" && collision.gameObject.tag == "fire")
        {
            uiManager.EnableButtonByTag("brick");
            Destroy(this.gameObject);
        }


        if (gameObject.tag == "fire" && collision.gameObject.tag == "clay" ||
gameObject.tag == "clay" && collision.gameObject.tag == "fire")
        {
            uiManager.EnableButtonByTag("brick");
            Destroy(this.gameObject);
        }


        if (gameObject.tag == "fire" && collision.gameObject.tag == "smoke" ||
gameObject.tag == "smoke" && collision.gameObject.tag == "fire")
        {
            uiManager.EnableButtonByTag("electric");
            Destroy(this.gameObject);
        }


        if (gameObject.tag == "electric" && collision.gameObject.tag == "cloud" ||
gameObject.tag == "cloud" && collision.gameObject.tag == "electric")
        {
            uiManager.EnableButtonByTag("thunder cloud");
            Destroy(this.gameObject);
        }


        if (gameObject.tag == "electric" && collision.gameObject.tag == "smoke" ||
gameObject.tag == "smoke" && collision.gameObject.tag == "electric")
        {
            uiManager.EnableButtonByTag("steam generator");
            Destroy(this.gameObject);
        }


        if (gameObject.tag == "brick" && collision.gameObject.tag == "rock" ||
gameObject.tag == "rock" && collision.gameObject.tag == "brick")
        {
            uiManager.EnableButtonByTag("castle");
            Destroy(this.gameObject);
        }
    }

}
