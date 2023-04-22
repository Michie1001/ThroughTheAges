using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimelineController : MonoBehaviour
{
    private int timeline = 0; 

    public void Yamato()
    {
        SceneManager.LoadScene(timeline + 1);
    }
    public void Nara()
    {
        SceneManager.LoadScene(timeline + 2);
    }
    public void Heian()
    {
        SceneManager.LoadScene(timeline + 3);
    }
    public void Kamakura()
    {
        SceneManager.LoadScene(timeline + 4);
    }
    public void AzuchiMomoyama()
    {
        SceneManager.LoadScene(timeline + 5);
    }
    public void PostWar()
    {
        SceneManager.LoadScene(timeline + 6);
    }
}
