using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MContinue()
    {
        SceneManager.LoadScene("Game");
    }

    public void MMap()
    {
        SceneManager.LoadScene("Map");
    }

    public void MGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void MMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void MExit()
    {
        
    }
}
