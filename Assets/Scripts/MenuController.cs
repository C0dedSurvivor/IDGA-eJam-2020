using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject creditsPanel;

    public void ToGame()
    {

    }

    public void ToTitle()
    {
        creditsPanel.SetActive(false);
    }

    public void ToCredits()
    {
        creditsPanel.SetActive(true);
    }
}
