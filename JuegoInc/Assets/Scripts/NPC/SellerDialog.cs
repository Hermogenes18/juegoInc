using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellerDialog : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool playerInRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || playerInRange)
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("choco");
        if (other.CompareTag("Seller")) 
        {
            //Debug.Log("choco");
            playerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("salio");
        if (other.CompareTag("Player"))
        {
            //Debug.Log("salio");
            playerInRange = false;
            dialogBox.SetActive(false);
        }
    }
}
