using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holdObject : MonoBehaviour
{
    private bool isFilled = false;
    public int ResistanceVal;
    public AudioSource slotfill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "resistor" && !isFilled)
        {
            collision.gameObject.transform.position = gameObject.transform.position;
            moveObject mO = collision.GetComponent<moveObject>();
            ResistanceVal = mO.ResistanceVal;
            isFilled= true;
            slotfill.Play();
            Debug.Log("ISFILLED! with " + ResistanceVal);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "resistor" && isFilled)
        {
            ResistanceVal = 0;
            isFilled = false;
        }
    }
}
