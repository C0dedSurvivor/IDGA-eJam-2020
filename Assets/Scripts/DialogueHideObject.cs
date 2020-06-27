using System.Collections.Generic;
using UnityEngine;

class DialogueHideObject : DialogueNode
{
    public GameObject target;

    public DialogueHideObject(GameObject target, List<DialogueNode> path = null) : base(path)
    {
        this.target = target;
    }
}
