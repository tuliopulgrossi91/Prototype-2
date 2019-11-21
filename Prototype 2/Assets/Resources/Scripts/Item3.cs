using UnityEngine;
using UnityEngine.UI;

public class Item3 : MonoBehaviour
{
    private Vector3 pos;
    public static bool drag, check, check_score;
    private Image spr_Element;
    public static Sprite spritesElements;
    public static Text text_Select; // text select
    public static string name_select;
    public static string alt_Item3;
    private AudioSource audio_Source;

    void Start()
    {
        text_Select = GameObject.FindGameObjectWithTag("TextSelect2").GetComponent<Text>();
        drag = false;
        check = false;
        check_score = false;
        pos = gameObject.transform.position;
        spritesElements = Resources.Load<Sprite>("Sprites/Elements/2");
        spr_Element = GetComponent<Image>();
        spr_Element.sprite = spritesElements;
        text_Select.text = alt_Item3;
        name_select = text_Select.text;
        audio_Source = GetComponent<AudioSource>();
    }

    void Update()
    {
        spr_Element.sprite = spritesElements;
        text_Select.text = alt_Item3;
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
        if(drag == true)
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
}