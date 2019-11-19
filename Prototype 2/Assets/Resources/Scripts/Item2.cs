using UnityEngine;
using UnityEngine.UI;

public class Item2 : MonoBehaviour
{
    private Vector3 pos;
    public static bool drag, check, check_score;
    private Image spr_Element;
    public static Sprite spritesElements;
    public static Text text_Select; // text select
    public static string name_select;
    public static string alt_Item2;

    void Start()
    {
        text_Select = GameObject.FindGameObjectWithTag("TextSelect1").GetComponent<Text>();
        drag = false;
        check = false;
        check_score = false;
        pos = gameObject.transform.position;
        spritesElements = Resources.Load<Sprite>("Sprites/Elements/1");
        spr_Element = GetComponent<Image>();
        spr_Element.sprite = spritesElements;
        text_Select.text = alt_Item2;
        name_select = text_Select.text;
    }

    void Update()
    {
        spr_Element.sprite = spritesElements;
        text_Select.text = alt_Item2;
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
}