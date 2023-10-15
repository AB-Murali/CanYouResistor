using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int[] reqResistance;
    public GameObject[] holders;
    bool correctSlots = false;

    public AudioSource crtConnection;
    public AudioSource wrgConnection;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void start_connection()
    {
        
        for (int i = 0; i < holders.Length; i++)
        {
            holdObject h = holders[i].GetComponent<holdObject>();
            if(h.ResistanceVal == reqResistance[i])
            {
                correctSlots = true;
                Debug.Log(true);
            }
            else
            {
                correctSlots = false;
                break;
            }
        }

        if (correctSlots)
        {
            crtConnection.Play();
            Invoke("next_level", 0.5f);
        }
        else
        {
            wrgConnection.Play();
            Invoke("reset_game", 0.5f);
        }
    }

    

    void next_level()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void reset_game()
    {
        SceneManager.LoadScene(1);
    }
}
