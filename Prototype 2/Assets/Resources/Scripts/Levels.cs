using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{
    public GameObject LevelManager, Settings; // panels
    public Button Level1, Level2, Level3, Level4, Level5; // levels buttons
    public GameObject Stars_Level0, Stars_Level1, Stars_Level2, Stars_Level3, Stars_Level4, Stars_Level5; // stars levels
    public static int load, score0, record0, score1, record1, score2, record2, score3, record3, score4, record4, score5, record5; // load, score and record count  
    public GameObject anima0, anima1, anima2, anima3, anima4, anima5;

    public void LevelGame(bool l) => LevelManager.SetActive(l); // level game
    public void SettingsGame(bool s)
    {
        Settings.SetActive(s); // settings game
        CheckLevels();
    }
    public void SelectLevel(int level) => load = level; // select level
    public void LoadLevel() => SceneManager.LoadScene(2); // load level game
    public void BackMenu() => SceneManager.LoadScene(0); // back menu game

    void Start()
    {
        Time.timeScale = 1;
        record0 = PlayerPrefs.GetInt("Record0");
        record1 = PlayerPrefs.GetInt("Record1");
        record2 = PlayerPrefs.GetInt("Record2");
        record3 = PlayerPrefs.GetInt("Record3");
        record4 = PlayerPrefs.GetInt("Record4");
        record5 = PlayerPrefs.GetInt("Record5");
        CheckLevels();
    }

    void CheckLevels()
    {
        #region Level0
        if (record0 == 10)
        {
            Stars_Level0.SetActive(true);
            Level1.interactable = true;
            anima0.GetComponent<Animator>().SetBool("anima", false);
            anima1.GetComponent<Animator>().SetBool("anima", true);
        }
        if (record0 < 10)
        {
            anima0.GetComponent<Animator>().SetBool("anima", true);
        }
        #endregion

        #region Level1
        if (record1 == 10)
        {
            Stars_Level1.SetActive(true);
            Level2.interactable = true;
            anima1.GetComponent<Animator>().SetBool("anima", false);
            anima2.GetComponent<Animator>().SetBool("anima", true);
        }
        if (record0 == 10 && record1 < 10)
        {
            anima1.GetComponent<Animator>().SetBool("anima", true);
        }
        #endregion

        #region Level2
        if (record2 == 10)
        {
            Stars_Level2.SetActive(true);
            Level3.interactable = true;
            anima2.GetComponent<Animator>().SetBool("anima", false);
            anima3.GetComponent<Animator>().SetBool("anima", true);
        }
        if (record1 == 10 && record2 < 10)
        {
            anima2.GetComponent<Animator>().SetBool("anima", true);
        }
        #endregion

        #region Level3
        if (record3 == 10)
        {
            Stars_Level3.SetActive(true);
            Level4.interactable = true;
            anima3.GetComponent<Animator>().SetBool("anima", false);
            anima4.GetComponent<Animator>().SetBool("anima", true);
        }
        if (record2 == 10 && record3 < 10)
        {
            anima3.GetComponent<Animator>().SetBool("anima", true);
        }
        #endregion

        #region Level4
        if (record4 == 10)
        {
            Stars_Level4.SetActive(true);
            Level5.interactable = true;
            anima4.GetComponent<Animator>().SetBool("anima", false);
            anima5.GetComponent<Animator>().SetBool("anima", true);
        }
        if (record3 == 10 && record4 < 10)
        {
            anima4.GetComponent<Animator>().SetBool("anima", true);
        }
        #endregion

        #region Level5
        if (record5 == 10)
        {
            Stars_Level5.SetActive(true);
            anima5.GetComponent<Animator>().SetBool("anima", false);
        }
        if (record4 == 10 && record5 < 10)
        {
            anima5.GetComponent<Animator>().SetBool("anima", true);
        }
        #endregion
    }
}