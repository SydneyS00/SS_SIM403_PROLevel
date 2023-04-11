using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UI_Manager : MonoBehaviour
{
    //I know that I do not need these variables but it helps keep 
    //my mind organized when writing

    [Header("Buttons")]
    public Button tooEasyButton;
    public Button tooHardButton;
    public Button justRightButton;

    public Button level01;
    public Button level02; 

    //This is the code for the tooEasyButton
    public void goToEasy()
    {
        SceneManager.LoadScene("TooEasy");
        Debug.Log("You have loaded into the Too Easy level");
    }

    //This is the code for the tooHardButton
    public void goToHard()
    {
        SceneManager.LoadScene("TooHard");
        Debug.Log("You have loaded into the hard level");
    }


    //This is the code for the justRightButton
    public void goToJustRight()
    {
        SceneManager.LoadScene("JustRight");
        Debug.Log("You have loaded into the Just Right Level");
    }


    //Level01 - level02
    public void goTo02()
    {
        SceneManager.LoadScene("Scene02");
        Debug.Log("Loaded into level02");
    }

    public void goTo01()
    {
        SceneManager.LoadScene("Scene01");
        Debug.Log("Loaded into level01");

    }
}
