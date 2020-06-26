using System.Collections.Generic;

public class DialogueLine : DialogueNode
{
    //Who or what is talking
    public string speaker;
    //The line they are saying
    public string line;

    public DialogueLine(string line, List<DialogueNode> path = null) : base(path)
    {
        speaker = "";
        this.line = line;
    }

    public DialogueLine(string speaker, string line, List<DialogueNode> path = null) : base(path)
    {
        this.speaker = speaker;
        this.line = line;
    }

    public override DialogueNode GetNext()
    {
        return dialoguePath?[0];
    }
}