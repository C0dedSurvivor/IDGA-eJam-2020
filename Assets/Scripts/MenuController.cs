using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject howToPlayPanel;
    [SerializeField]
    private GameObject creditsPanel;

    public void ToGame()
    {
        SceneManager.LoadScene("Room1");
    }

    public void ToTitle()
    {
        creditsPanel.SetActive(false);
        howToPlayPanel.SetActive(false);
    }

    public void ToHowToPlay()
    {
        howToPlayPanel.SetActive(true);
    }

    public void ToCredits()
    {
        creditsPanel.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
