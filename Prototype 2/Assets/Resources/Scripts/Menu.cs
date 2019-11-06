using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }

    public GameObject MenuManager, Settings, Credits, Exit;

    // menu game
    public void MenuGame(bool m) => MenuManager.SetActive(m);

    // settings game
    public void SettingsGame(bool s) => Settings.SetActive(s);

    // credits game
    public void CreditsGame(bool c) => Credits.SetActive(c);

    // exit game
    public void ExitGame(bool c) => Exit.SetActive(c);

    // confirm exit game
    public void ConfirmExitGame() => Application.Quit();

    // load level
    public void LoadLevel() => SceneManager.LoadScene(1);

    public void ResetRecord()
    {
        PlayerPrefs.DeleteKey("Record0");
        PlayerPrefs.DeleteKey("Record1");
        PlayerPrefs.DeleteKey("Record2");
        PlayerPrefs.DeleteKey("Record3");
        PlayerPrefs.DeleteKey("Record4");
        PlayerPrefs.DeleteKey("Record5");
    }
}