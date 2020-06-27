using System.Collections.Generic;
using UnityEngine;

public class DialogueLine : DialogueNode
{
    //Who or what is talking
    public string speaker;
    //The line they are saying
    public string line;
    //What key to press to move to the next node
    public KeyCode continueKey;

    public DialogueLine(string line, KeyCode continueKey = KeyCode.Return, List<DialogueNode> path = null) : base(path)
    {
        speaker = "";
        this.line = line;
        this.continueKey = continueKey;
    }

    public DialogueLine(string speaker, string line, KeyCode continueKey = KeyCode.Return, List<DialogueNode> path = null) : base(path)
    {
        this.speaker = speaker;
        this.line = line;
        this.continueKey = continueKey;
    }
}