using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{
    public GameObject LevelManager, Settings; // panels
    public Button Level1, Level2, Level3, Level4, Level5; // levels buttons
    public GameObject Stars_Level0, Stars_Level1, Stars_Level2, Stars_Level3, Stars_Level4, Stars_Level5; // stars levels
    public static int load, score, record; // load, score and record count  

    public void LevelGame(bool l) => LevelManager.SetActive(l); // level game
    public void SettingsGame(bool s) => Settings.SetActive(s); // settings game
    public void SelectLevel(int level) => load = level; // select level
    public void LoadLevel() => SceneManager.LoadScene(2); // load level game
    public void BackMenu() => SceneManager.LoadScene(0); // back menu game

    void Start()
    {
        Time.timeScale = 1;
        record = PlayerPrefs.GetInt("Record");
        Debug.Log(record);
        CheckLevels();
    }

    void CheckLevels()
    {
        #region Level0

        if (record == 10)
        {
            Stars_Level0.SetActive(true);
            Level1.enabled = true;
        }
        #endregion

        #region Level1
        if (record == 20)
        {
            Stars_Level1.SetActive(true);
            Level2.enabled = true;
        }
        #endregion

        #region Level2
        if (record == 30)
        {
            Stars_Level2.SetActive(true);
            Level3.enabled = true;
        }
        #endregion

        #region Level3
        if (record == 40)
        {
            Stars_Level3.SetActive(true);
            Level4.enabled = true;
        }
        #endregion

        #region Level4
        if (record == 50)
        {
            Stars_Level4.SetActive(true);
            Level5.enabled = true;
        }
        #endregion

        #region Level5
        if (record == 60)
        {
            Stars_Level5.SetActive(true);
        }
        #endregion
    }
}