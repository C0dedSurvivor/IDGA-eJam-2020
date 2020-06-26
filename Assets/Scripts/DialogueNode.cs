using System.Collections.Generic;

public abstract class DialogueNode
{
    public List<DialogueNode> dialoguePath;

    protected DialogueNode(List<DialogueNode> path = null)
    {
        dialoguePath = path;
    }

    /// <summary>
    /// Gets the next node to act on in this chain if there is one
    /// </summary>
    /// <returns>The next node if it exists, null if it doesn't</returns>
    public abstract DialogueNode GetNext();
}