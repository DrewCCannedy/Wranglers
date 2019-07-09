using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text targetNameText;
    public Text targetSideNameText;
    public Text dialogueText;
    public Animator animator;

    private Queue<string> sentences;

    // Use this for initialization
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("isOpen", true);
        if (dialogue.doubleConvo)
            animator.SetBool("isDouble", true);
        nameText.text = dialogue.character;
        targetNameText.text = dialogue.targetCharacter;
        targetSideNameText.text = dialogue.character;


        sentences.Clear();

        foreach (Speech sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence.text);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("isOpen", false);
        animator.SetBool("isDouble", false);
    }

}