using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[System.Serializable]
public class Dialogue
{
        public string character;
        public string targetCharacter;
        public string targetSideCharacter;
        public Speech[] sentences;

        public bool doubleConvo;
}
[System.Serializable]
public class Speech
{
    public enum Choices
    {
        character,
        targetCharacter,
        targetSideCharacter
    }
    public Choices speaker;
    [TextArea]
    public string text;
}