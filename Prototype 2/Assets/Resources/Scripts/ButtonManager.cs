using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    private Animator anima;

    void Start()
    {
        anima = GetComponent<Animator>();
        anima.enabled = true;
    }

    void Update()
    {
        if (Item.drag == false || Item2.drag == false || Item3.drag == false)
        {
            anima.SetBool("anima", true);
        }
        if (Item.drag == true || Item2.drag == true || Item3.drag == true)
        {
            anima.SetBool("anima", false);
        }
    }
}