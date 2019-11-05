using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public GameObject Questions, Pause, Settings, Results; // panels
    public GameObject GameOver; // timer 0
    public Text text_Time; // text time
    public Text text_Question, text_Count, text_Result; // text question, count, result
    public Text text_Score, text_Record; // texts score and record
    public static int count_quest; // counter number of questions
    public static int quest_list; // receive question list
    public float count_time; // counter time
    public static bool finish; // check game status
    public static string name_result;

    #region BUTTONS AND PANELS
    public void QuestionsGame(bool q) => Questions.SetActive(q); // questions game
    public void OnApplicationPause(bool pause)
    {
        Pause.SetActive(pause); // pause game

        if (pause == false)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
    public void SettingsGame(bool s) => Settings.SetActive(s); // settings game
    public void RetryGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // retry game
    public void BackLevels() => SceneManager.LoadScene(1); // back levels game 
    #endregion

    void Start()
    {
        QuestList();
        count_quest = 0;
        count_time = 120f;
        finish = false;
        GameOver.SetActive(false);
        text_Result.text = name_result.ToString();
        text_Count.text = "" + count_quest.ToString();
        Time.timeScale = 1;
    }

    void Update()
    {
        #region CHECK TIME GAME
        text_Time.text = Mathf.Round(count_time).ToString();
        count_time -= Time.deltaTime;
        #endregion

        #region CHECK FINISH GAME
        if (count_time < 0)
        {
            Questions.SetActive(false);
            Results.SetActive(true);
            GameOver.SetActive(true);
        }

        if (finish == true) // game finish - show results
        {
            Questions.SetActive(false);
            Results.SetActive(true);
        }

        if (Levels.score > Levels.record)
        {
            Levels.record = Levels.score;
            PlayerPrefs.SetInt("Record", Levels.record);
        }

        text_Score.text = "Pontos: " + Levels.score.ToString();
        text_Record.text = "Total: " + Levels.record.ToString();
        #endregion

        if (Item.check == true)
        {
            Item.check = false;
            NextQuest();
        }

        text_Result.text = name_result;
    }

    void QuestList()
    {
        switch (Levels.load)
        {
            case 0: // Level 0
                text_Question.text = "" + List.numbers[quest_list];
                break;
            case 1: // Level 1
                text_Question.text = "" + List.symbols[quest_list];
                break;
            case 2: // Level 2
                text_Question.text = "" + List.names[quest_list];
                break;
            case 3: // Level 3
                text_Question.text = "" + List.mass[quest_list];
                break;
            case 4: // Level 4
                text_Question.text = "" + List.period[quest_list];
                break;
            case 5: // Level 5
                text_Question.text = "" + List.family[quest_list];
                break;
        }
    }

    void NextQuest()
    {
        if (count_quest > 9)
        {
            finish = true;
        }
        else
        {
            text_Count.text = "" + count_quest.ToString();

            if (quest_list < 10)
            {
                quest_list++;
            }
            QuestList();
            Item.CheckRandom();
        }
    }
}