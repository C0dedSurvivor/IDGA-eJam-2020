using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject creditsPanel;

    public void ToGame()
    {
        SceneManager.LoadScene("Room1");
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
