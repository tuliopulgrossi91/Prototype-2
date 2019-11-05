using UnityEngine;

public class Select : MonoBehaviour
{
    public static bool press; // check select press
    public void ClickMe() => press = !press;
    public void ChangeText() => Item.text_Select.text = Item.alts[Item.i];
}