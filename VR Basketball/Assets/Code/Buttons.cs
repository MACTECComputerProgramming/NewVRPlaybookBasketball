using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    //char sel
    public void player1()
    {

    }
    public void player2()
    {

    }
    public void player3()
    {

    }
    public void player4()
    {

    }
    public void player5()
    {

    }



    //home page
    public void GuittGame()
    {
        Application.Quit();
    }
    public void toInfo()
    {
        SceneManager.LoadScene("Info");
    }
    public void toplaySLT1_6()
    {
        SceneManager.LoadScene("Plays1-6");
    }
    public void toplaySLT7_12()
    {
        SceneManager.LoadScene("Plays7-12");
    }
    public void toplaySLT13_16()
    {
        SceneManager.LoadScene("Plays13-16");
    }
    public void backtomain()
    {
        SceneManager.LoadScene("main menu");
    }
    public void toplayerSel()
    {

    }
}

