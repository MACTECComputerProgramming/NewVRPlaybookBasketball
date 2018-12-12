using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour
{
    int playnumber = 0;
    int playernumber = 0;

    //char sel
    public void player1()
    {
        playernumber = 1;
        wheretosend(playnumber, playernumber);
    }

    
    public void player2()
    {
        playernumber = 2;
        wheretosend(playnumber, playernumber);
    }
    public void player3()
    {
        playernumber = 3;
        wheretosend(playnumber, playernumber);
    }
    public void player4()
    {
        playernumber = 4;
        wheretosend(playnumber, playernumber);
    }
    public void player5()
    {
        playernumber = 5;
        wheretosend(playnumber, playernumber);
    }

    private void wheretosend(int playnumber, int playernumber)
    {
        if (playnumber == 1 )
        {
            SceneManager.LoadScene("Court");
        }
    }
    //plays and add to val
    public void fist1()
    {
        playnumber = 1;
        SceneManager.LoadScene("PlayerSel");
    }
    public void Clipper2()
    {
        playnumber = 2;
        SceneManager.LoadScene("PlayerSel");
    }
    public void Swing3()
    {
        playnumber = 3;
        SceneManager.LoadScene("PlayerSel");
    }
    public void SwingDown4()
    {
        playnumber = 4;
        SceneManager.LoadScene("PlayerSel");
    }
    public void Cross5()
    {
        playnumber = 5;
        SceneManager.LoadScene("PlayerSel");
    }
    public void Dive6()
    {
        playnumber = 6;
        SceneManager.LoadScene("PlayerSel");
    }
    public void Trail7()
    {
        playnumber = 7;
        SceneManager.LoadScene("PlayerSel");
    }
    public void Lift8()
    {
        playnumber = 8;
        SceneManager.LoadScene("PlayerSel");
    }
    public void Circle9()
    {
        playnumber = 9;
        SceneManager.LoadScene("PlayerSel");
    }
    public void Rocket10()
    {
        playnumber = 10;
        SceneManager.LoadScene("PlayerSel");
    }
    public void Euro11()
    {
        playnumber = 11;
        SceneManager.LoadScene("PlayerSel");
    }
    public void Stay12()
    {
        playnumber = 12;
        SceneManager.LoadScene("PlayerSel");
    }
    public void Exchange13()
    {
        playnumber = 13;
        SceneManager.LoadScene("PlayerSel");
    }
    public void Across14()
    {
        playnumber = 14;
        SceneManager.LoadScene("PlayerSel");
    }
    public void Zipper15()
    {
        playnumber = 15;
        SceneManager.LoadScene("PlayerSel");
    }
    public void Warrior16()
    {
        playnumber = 16;
        SceneManager.LoadScene("PlayerSel");
    }

    //change scene with no math
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
        SceneManager.LoadScene("PlayerSel");
    }
}

