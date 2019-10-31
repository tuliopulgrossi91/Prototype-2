using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject Questions, Pause, Settings, Results;
    private readonly bool finish;

    public void QuestionsGame(bool q) => Questions.SetActive(q); // questions game
    public void OnApplicationPause(bool pause) => Pause.SetActive(pause); // pause game
    public void SettingsGame(bool s) => Settings.SetActive(s); // settings game
    public void RetryGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // retry game
    public void BackLevels() => SceneManager.LoadScene(1); // back levels game

    void Update()
    {
        if (finish == true) // game finish - show results
        {
            Questions.SetActive(false);
            Results.SetActive(true);
        }
    }
}