using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    protected List<DialogueNode> toDisplay = new List<DialogueNode>();
    [SerializeField]
    private TextAnimator textAnimator;
    //If dialogue is currently happening, makes sure it doesn't interrupt it with a new line
    private bool animatingText = false;

    /// <summary>
    /// Is true if the text animator is done displaying all text from the queue
    /// </summary>
    public bool Done { get { return textAnimator.Done && toDisplay.Count == 0; } }

    void Start()
    {
        if (textAnimator == null)
            textAnimator = GetComponent<TextAnimator>();
    }

    /// <summary>
    /// If the text animator is done working with its current line, see if there is anything else to do
    /// </summary>
    void Update()
    {
        if(animatingText && textAnimator.Done)
        {
            animatingText = false;
            ToNextNode();
        }
    }

    /// <summary>
    /// Adds and starts the dialogue tree from an interactable if this is not already in use
    /// </summary>
    /// <param name="interactableName">The name of the dialogue tree to display</param>
    public void StartDialogue(string interactableName)
    {
        if (Done)
        {
            Enqueue(GameStorage.interactableDialogues[interactableName]);
        }
    }

    /// <summary>
    /// Finds out what the next node to act on is, returns if there's nothing else to do
    /// </summary>
    private void ToNextNode()
    {
        DialogueNode next = toDisplay[0]?.GetNext();
        if (next == null)
        {
            toDisplay.RemoveAt(0);
            if (toDisplay.Count == 0)
                return;
        }
        ProcessNewNode();
    }

    /// <summary>
    /// Sets up the currently queued node to be acted on
    /// </summary>
    private void ProcessNewNode()
    {
        if (toDisplay.Count > 0)
        {
            DialogueNode next = toDisplay[0];
            if (next is DialogueLine)
            {
                textAnimator.Enqueue(next as DialogueLine);
                animatingText = true;
            }
        }
    }

    /// <summary>
    /// Adds a dialog set to the queue of text to show
    /// </summary>
    /// <param name="lines">The dialog set to display</param>
    public void Enqueue(List<DialogueNode> lines)
    {
        toDisplay.AddRange(lines);
        if (toDisplay.Count == lines.Count)
            ProcessNewNode();
    }
}