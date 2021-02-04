using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BttnPlay()
    {
        SceneManager.LoadScene("Week1");
        print("Play");
    }

    public void BttnAbout()
    {
        print("about");
    }

    public void BttnQuit() 
    {
        print("Quit");
        Application.Quit();
    }
}
