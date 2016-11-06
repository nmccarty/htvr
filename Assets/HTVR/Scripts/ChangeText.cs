using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    public Text instruction;
    public float letterPause = 0.01f;
    string message;
    string[] lines;
    int pos;
    int linesIn;

    void Awake()
    {
       // instruction = GetComponent<Text>();
        message = "";
        lines = System.IO.File.ReadAllLines(@"C:\Users\nmccarty\Desktop\code.txt");
        pos = 0;
        linesIn = 0;
    }


    public void ChangeTextS()
    {
        if (linesIn > 20)
        { // Forgive my magic number
            linesIn = 0;
            instruction.text = "";
        }

        if (pos >= lines.Length)
        {
            pos = 0;
        }

        message = lines[pos];
        while (message.Length < 5)
        {
            message += "\n" + lines[++pos];
        }
        pos++;
        // StartCoroutine(TypeText());
        instruction.text += message;
        linesIn++;
    }

    IEnumerator TypeText()
    {
        foreach (char letter in message.ToCharArray())
        {
            instruction.text += letter;

            yield return 0;
            yield return new WaitForSeconds(letterPause);
        }
        instruction.text += "\n";
    }
}
