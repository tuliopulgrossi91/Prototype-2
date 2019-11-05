using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    private Vector3 pos;
    public static int i, r;
    public static bool drag, check, check_score;
    private Image spr_Element;
    public static Sprite[] spritesElements = new Sprite[3];
    public static Text text_Select; // text select
    public static string name_select;
    public static string [] alts = new string[3];

    void Start()
    {
        i = 0;
        CheckRandom();
        text_Select = GameObject.FindGameObjectWithTag("TextSelect").GetComponent<Text>();
        drag = false;
        check = false;
        check_score = false;
        pos = gameObject.transform.position;
        spritesElements[0] = Resources.Load<Sprite>("Sprites/Elements/0");
        spritesElements[1] = Resources.Load<Sprite>("Sprites/Elements/1");
        spritesElements[2] = Resources.Load<Sprite>("Sprites/Elements/2");
        spr_Element = GetComponent<Image>();
        spr_Element.sprite = spritesElements[i];
        text_Select.text = alts[i];
        name_select = text_Select.text;
    }

    void Update()
    {
        spr_Element.sprite = spritesElements[i];
        text_Select.text = alts[i];
        name_select = text_Select.text;

        if (Select.press == true)
        {
            if (check == false)
            {
                i++;
                if (i > 2)
                {
                    i = 0;
                }
            }
            Select.press = false;
        }

        if(check_score == true)
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
    }

    public void DragItem()
    {
        transform.position = Input.mousePosition;
    }

    public void PointerUpItem()
    {
        gameObject.transform.position = pos;
        drag = false;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Quest")
        {
            LevelManager.count_quest++;
            check = true;

            if (LevelManager.name_result == name_select)
            {
                Debug.Log("Igual!");
                check_score = true;
            }
            else
            {
                Debug.Log("Diferente!");
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
        r = Random.Range(0, 3);

        if (r == 0)
        {
            // result = alt 1

            switch (Levels.load)
            {
                case 0: // Level 0
                    alts[0] = "" + List.numbers_right[LevelManager.quest_list];
                    alts[1] = "" + List.numbers_alt1[LevelManager.quest_list];
                    alts[2] = "" + List.numbers_alt2[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.numbers_right[LevelManager.quest_list];
                    break;
                case 1: // Level 1
                    alts[0] = "" + List.symbols_right[LevelManager.quest_list];
                    alts[1] = "" + List.symbols_alt1[LevelManager.quest_list];
                    alts[2] = "" + List.symbols_alt2[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.symbols_right[LevelManager.quest_list];
                    break;
                case 2: // Level 2
                    alts[0] = "" + List.names_right[LevelManager.quest_list];
                    alts[1] = "" + List.names_alt1[LevelManager.quest_list];
                    alts[2] = "" + List.names_alt2[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.names_right[LevelManager.quest_list];
                    break;
                case 3: // Level 3
                    alts[0] = "" + List.mass_right[LevelManager.quest_list];
                    alts[1] = "" + List.mass_alt1[LevelManager.quest_list];
                    alts[2] = "" + List.mass_alt2[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.mass_right[LevelManager.quest_list];
                    break;
                case 4: // Level 4
                    alts[0] = "" + List.period_right[LevelManager.quest_list];
                    alts[1] = "" + List.period_alt1[LevelManager.quest_list];
                    alts[2] = "" + List.period_alt2[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.period_right[LevelManager.quest_list];
                    break;
                case 5: // Level 5
                    alts[0] = "" + List.family_right[LevelManager.quest_list];
                    alts[1] = "" + List.family_alt1[LevelManager.quest_list];
                    alts[2] = "" + List.family_alt2[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.family_right[LevelManager.quest_list];
                    break;
            }
        }
        if (r == 1)
        {
            // result = alt 2

            switch (Levels.load)
            {
                case 0: // Level 0
                    alts[0] = "" + List.numbers_alt1[LevelManager.quest_list];
                    alts[1] = "" + List.numbers_right[LevelManager.quest_list];
                    alts[2] = "" + List.numbers_alt2[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.numbers_right[LevelManager.quest_list];
                    break;
                case 1: // Level 1
                    alts[0] = "" + List.symbols_alt1[LevelManager.quest_list];
                    alts[1] = "" + List.symbols_right[LevelManager.quest_list];
                    alts[2] = "" + List.symbols_alt2[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.symbols_right[LevelManager.quest_list];
                    break;
                case 2: // Level 2
                    alts[0] = "" + List.names_alt1[LevelManager.quest_list];
                    alts[1] = "" + List.names_right[LevelManager.quest_list];
                    alts[2] = "" + List.names_alt2[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.names_right[LevelManager.quest_list];
                    break;
                case 3: // Level 3
                    alts[0] = "" + List.mass_alt1[LevelManager.quest_list];
                    alts[1] = "" + List.mass_right[LevelManager.quest_list];
                    alts[2] = "" + List.mass_alt2[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.mass_right[LevelManager.quest_list];
                    break;
                case 4: // Level 4
                    alts[0] = "" + List.period_alt1[LevelManager.quest_list];
                    alts[1] = "" + List.period_right[LevelManager.quest_list];
                    alts[2] = "" + List.period_alt2[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.period_right[LevelManager.quest_list];
                    break;
                case 5: // Level 5
                    alts[0] = "" + List.family_alt1[LevelManager.quest_list];
                    alts[1] = "" + List.family_right[LevelManager.quest_list];
                    alts[2] = "" + List.family_alt2[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.family_right[LevelManager.quest_list];
                    break;
            }
        }
        if (r == 2)
        {
            // result = alt 3

            switch (Levels.load)
            {
                case 0: // Level 0
                    alts[0] = "" + List.numbers_alt1[LevelManager.quest_list];
                    alts[1] = "" + List.numbers_alt2[LevelManager.quest_list];
                    alts[2] = "" + List.numbers_right[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.numbers_right[LevelManager.quest_list];
                    break;
                case 1: // Level 1
                    alts[0] = "" + List.symbols_alt1[LevelManager.quest_list];
                    alts[1] = "" + List.symbols_alt2[LevelManager.quest_list];
                    alts[2] = "" + List.symbols_right[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.symbols_right[LevelManager.quest_list];
                    break;
                case 2: // Level 2
                    alts[0] = "" + List.names_alt1[LevelManager.quest_list];
                    alts[1] = "" + List.names_alt2[LevelManager.quest_list];
                    alts[2] = "" + List.names_right[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.names_right[LevelManager.quest_list];
                    break;
                case 3: // Level 3
                    alts[0] = "" + List.mass_alt1[LevelManager.quest_list];
                    alts[1] = "" + List.mass_alt2[LevelManager.quest_list];
                    alts[2] = "" + List.mass_right[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.mass_right[LevelManager.quest_list];
                    break;
                case 4: // Level 4
                    alts[0] = "" + List.period_alt1[LevelManager.quest_list];
                    alts[1] = "" + List.period_alt2[LevelManager.quest_list];
                    alts[2] = "" + List.period_right[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.period_right[LevelManager.quest_list];
                    break;
                case 5: // Level 5
                    alts[0] = "" + List.family_alt1[LevelManager.quest_list];
                    alts[1] = "" + List.family_alt2[LevelManager.quest_list];
                    alts[2] = "" + List.family_right[LevelManager.quest_list];
                    LevelManager.name_result = "" + List.family_right[LevelManager.quest_list];
                    break;
            }
        }
    }
}