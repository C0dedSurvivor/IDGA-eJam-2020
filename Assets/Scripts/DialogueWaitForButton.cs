using System.Collections.Generic;
using UnityEngine;

class DialogueWaitForButton : DialogueNode
{
    //Key to wait for
    public KeyCode key;

    public DialogueWaitForButton(KeyCode key, List<DialogueNode> path = null) : base(path)
    {
        this.key = key;
    }
}
