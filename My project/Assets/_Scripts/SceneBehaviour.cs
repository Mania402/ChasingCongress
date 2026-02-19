using PixelCrushers;
using PixelCrushers.DialogueSystem;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBehaviour : MonoBehaviour
{
    [SerializeField] GameObject _mainMenu;
    [SerializeField] GameObject _settingsMenu;

    bool showSettings;

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void showSettingsMenu()
    {
        _settingsMenu.gameObject.SetActive(true);
        showSettings = true;
        _mainMenu.gameObject.SetActive(false);
    }

    public void hideSettingsMenu()
    {
        _settingsMenu.gameObject.SetActive(false);
        showSettings = false;
        _mainMenu.gameObject.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit clicked, Game was quit in thought");
    }
}
