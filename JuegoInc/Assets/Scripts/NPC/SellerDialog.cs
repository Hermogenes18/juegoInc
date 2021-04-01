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
    public bool dialogeActive = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        //Comprovar si se solicito un dialogo
        if (dialogeActive == false && Input.GetKey(KeyCode.Space) && playerInRange)
        {
            
            dialogeActive = true;

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
        Debug.Log("mainkra");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("choco");
            playerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("salio");
            playerInRange = false;
            dialogBox.SetActive(false);
            dialogeActive = false;
        }
    }
}
