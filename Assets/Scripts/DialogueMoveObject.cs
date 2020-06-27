using System.Collections.Generic;
using UnityEngine;

class DialogueMoveObject : DialogueNode
{
    public GameObject target;
    public Vector3 position;

    public DialogueMoveObject(GameObject target, Vector3 position, List<DialogueNode> path = null) : base(path)
    {
        this.target = target;
        this.position = position;
    }
}
