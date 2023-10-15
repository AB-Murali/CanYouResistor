using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource uiSel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play_Game()
    {
        uiSel.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void stop_Game()
    {
        uiSel.Stop();
        Application.Quit();
    }
}
