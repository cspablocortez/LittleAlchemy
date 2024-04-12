using UnityEngine;
using UnityEngine.UI;

public class combination : MonoBehaviour
{
    public GameObject combinedElementPrefab; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        combination otherElement = collision.gameObject.GetComponent<combination>();

        if (otherElement != null)
        {
            gameManager.Instance.productTag = CombineElements(otherElement);
        } else
        {
            gameManager.Instance.productTag = "NO RETURN TAG PROVIDED";
        }

        if (collision.gameObject.name == "delete")
        {
            Destroy(this.gameObject);
        }
    }

    public string CombineElements(combination otherElement)
    {
        // Check if the combination is valid based on tags
        if ((this.CompareTag("water") && otherElement.CompareTag("air")) ||
            (this.CompareTag("fire") && otherElement.CompareTag("earth")) ||
            (this.CompareTag("water") && otherElement.CompareTag("fire")) ||
            (this.CompareTag("fire") && otherElement.CompareTag("water")) ||
            (this.CompareTag("earth") && otherElement.CompareTag("water")) ||
            (this.CompareTag("lava") && otherElement.CompareTag("water")) ||
            (this.CompareTag("mud") && otherElement.CompareTag("fire")) ||
            (this.CompareTag("rock") && otherElement.CompareTag("air")) ||
            (this.CompareTag("sand") && otherElement.CompareTag("water")) ||
            (this.CompareTag("air") && otherElement.CompareTag("fire")) ||
            (this.CompareTag("water vapor") && otherElement.CompareTag("air")) ||
            (this.CompareTag("smoke") && otherElement.CompareTag("cloud")) ||
            (this.CompareTag("clay") && otherElement.CompareTag("fire")) ||
            (this.CompareTag("thunder cloud") && otherElement.CompareTag("air")) ||
            (this.CompareTag("electric") && otherElement.CompareTag("water vapor")) ||
            (this.CompareTag("brick") && otherElement.CompareTag("rock")) ||
            (this.CompareTag("steam generator") && otherElement.CompareTag("electric")))
        {
 
            // Destroy the combining elements
            Destroy(otherElement.gameObject);
            Destroy(this.gameObject);

            // Spawn the combined element
            Instantiate(combinedElementPrefab, transform.position, Quaternion.identity);
            Debug.Log("CombineElements(): " + combinedElementPrefab.tag);
            return combinedElementPrefab.tag;
        }
        else
        {
            return "EMPTY STRING";
        }
    }
}