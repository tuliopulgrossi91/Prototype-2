using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public GameObject LevelManager, Settings;

    public void LevelGame(bool l) => LevelManager.SetActive(l); // level game
    public void SettingsGame(bool s) => Settings.SetActive(s); // settings game
    public void LoadLevel() => SceneManager.LoadScene(2); // load level game
    public void BackMenu() => SceneManager.LoadScene(0); // back menu game
}