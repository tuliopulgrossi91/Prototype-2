using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    private Vector3 pos;
    public static bool drag, check, check_score;
    private Image spr_Element;
    public static Sprite spritesElements;
    public static Text text_Select; // text select
    public static string name_select;
    public static string alt_Item;
    private AudioSource audio_Source;

    void Start()
    {
        CheckRandom();
        text_Select = GameObject.FindGameObjectWithTag("TextSelect").GetComponent<Text>();
        drag = false;
        check = false;
        check_score = false;
        pos = gameObject.transform.position;
        spritesElements = Resources.Load<Sprite>("Sprites/Elements/0");
        spr_Element = GetComponent<Image>();
        spr_Element.sprite = spritesElements;
        text_Select.text = alt_Item;
        name_select = text_Select.text;
        audio_Source = GetComponent<AudioSource>();
    }

    void Update()
    {
        spr_Element.sprite = spritesElements;
        text_Select.text = alt_Item;
        name_select = text_Select.text;

        if (check_score == true)
        {
            check_score = false;

            if (Levels.load == 0)
            {
                Levels.score0++;
            }
            if (Levels.load == 1)
            {
                Levels.score1++;
            }
            if (Levels.load == 2)
            {
                Levels.score2++;
            }
            if (Levels.load == 3)
            {
                Levels.score3++;
            }
            if (Levels.load == 4)
            {
                Levels.score4++;
            }
            if (Levels.load == 5)
            {
                Levels.score5++;
            }
        }
    }

    public void BeginDragItem()
    {
        drag = true;

        if (PlayerPrefs.GetInt("AUDIO") == 1)
        {
            audio_Source.PlayOneShot(Settings.auClipSfx0);
            audio_Source.volume = PlayerPrefs.GetFloat("VOLUMEAUDIO");
        }
    }

    public void DragItem()
    {
        if (drag == true)
        {
            transform.position = Input.mousePosition;
        }
    }

    public void PointerUpItem()
    {
        spr_Element.color = Color.white;
        gameObject.transform.position = pos;
        drag = false;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Quest")
        {
            LevelManager.count_quest++;
            gameObject.transform.position = pos;
            drag = false;
            check = true;

            if (LevelManager.name_result == name_select)
            {
                spr_Element.color = Color.green;
                check_score = true;

                if (PlayerPrefs.GetInt("AUDIO") == 1)
                {
                    audio_Source.PlayOneShot(Settings.auClipSfx1);
                    audio_Source.volume = PlayerPrefs.GetFloat("VOLUMEAUDIO");
                }
            }
            else
            {
                spr_Element.color = Color.red;

                if (PlayerPrefs.GetInt("AUDIO") == 1)
                {
                    audio_Source.PlayOneShot(Settings.auClipSfx2);
                    audio_Source.volume = PlayerPrefs.GetFloat("VOLUMEAUDIO");
                }
            }
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Quest")
        {
            check = false;
        }
    }

    public static void CheckRandom()
    {
            LevelManager.r = Random.Range(0, 3);

            if (LevelManager.r == 0)
            {
                // result = alt 1

                switch (Levels.load)
                {
                    case 0: // Level 0
                        alt_Item = "" + List.numbers_right[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.numbers_alt1[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.numbers_alt2[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.numbers_right[LevelManager.count_quest];
                        break;
                    case 1: // Level 1
                        alt_Item = "" + List.symbols_right[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.symbols_alt1[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.symbols_alt2[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.symbols_right[LevelManager.count_quest];
                        break;
                    case 2: // Level 2
                        alt_Item = "" + List.names_right[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.names_alt1[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.names_alt2[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.names_right[LevelManager.count_quest];
                        break;
                    case 3: // Level 3
                        alt_Item = "" + List.mass_right[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.mass_alt1[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.mass_alt2[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.mass_right[LevelManager.count_quest];
                        break;
                    case 4: // Level 4
                        alt_Item = "" + List.period_right[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.period_alt1[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.period_alt2[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.period_right[LevelManager.count_quest];
                        break;
                    case 5: // Level 5
                        alt_Item = "" + List.family_right[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.family_alt1[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.family_alt2[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.family_right[LevelManager.count_quest];
                        break;
                }
            }
            if (LevelManager.r == 1)
            {
                // result = alt 2

                switch (Levels.load)
                {
                    case 0: // Level 0
                        alt_Item = "" + List.numbers_alt1[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.numbers_right[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.numbers_alt2[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.numbers_right[LevelManager.count_quest];
                        break;
                    case 1: // Level 1
                        alt_Item = "" + List.symbols_alt1[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.symbols_right[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.symbols_alt2[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.symbols_right[LevelManager.count_quest];
                        break;
                    case 2: // Level 2
                        alt_Item = "" + List.names_alt1[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.names_right[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.names_alt2[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.names_right[LevelManager.count_quest];
                        break;
                    case 3: // Level 3
                        alt_Item = "" + List.mass_alt1[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.mass_right[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.mass_alt2[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.mass_right[LevelManager.count_quest];
                        break;
                    case 4: // Level 4
                        alt_Item = "" + List.period_alt1[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.period_right[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.period_alt2[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.period_right[LevelManager.count_quest];
                        break;
                    case 5: // Level 5
                        alt_Item = "" + List.family_alt1[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.family_right[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.family_alt2[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.family_right[LevelManager.count_quest];
                        break;
                }
            }
            if (LevelManager.r == 2)
            {
                // result = alt 3

                switch (Levels.load)
                {
                    case 0: // Level 0
                        alt_Item = "" + List.numbers_alt1[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.numbers_alt2[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.numbers_right[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.numbers_right[LevelManager.count_quest];
                        break;
                    case 1: // Level 1
                        alt_Item = "" + List.symbols_alt1[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.symbols_alt2[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.symbols_right[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.symbols_right[LevelManager.count_quest];
                        break;
                    case 2: // Level 2
                        alt_Item = "" + List.names_alt1[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.names_alt2[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.names_right[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.names_right[LevelManager.count_quest];
                        break;
                    case 3: // Level 3
                        alt_Item = "" + List.mass_alt1[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.mass_alt2[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.mass_right[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.mass_right[LevelManager.count_quest];
                        break;
                    case 4: // Level 4
                        alt_Item = "" + List.period_alt1[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.period_alt2[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.period_right[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.period_right[LevelManager.count_quest];
                        break;
                    case 5: // Level 5
                        alt_Item = "" + List.family_alt1[LevelManager.count_quest];
                        Item2.alt_Item2 = "" + List.family_alt2[LevelManager.count_quest];
                        Item3.alt_Item3 = "" + List.family_right[LevelManager.count_quest];
                        LevelManager.name_result = "" + List.family_right[LevelManager.count_quest];
                        break;
                }
            }
    }
}