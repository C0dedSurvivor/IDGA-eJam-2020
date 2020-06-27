using System.Collections.Generic;
using UnityEngine;

class GameStorage : MonoBehaviour
{
    public static Dictionary<string, List<DialogueNode>> interactableDialogues = new Dictionary<string, List<DialogueNode>>();
    public static Dictionary<string, Sprite> sprites = new Dictionary<string, Sprite>();

    //A serialized list of sprites to assist in loading in necessary images for quick-swapping
    [SerializeField]
    private List<Sprite> spriteLoader = new List<Sprite>();

    [SerializeField]
    private SpriteRenderer dialogueBackground;

    void Start()
    {
        interactableDialogues.Add(
            "test interactable", new List<DialogueNode>()
            {
                new DialogueLine("Speaker 1", "Hi, I'm speaking now."),
                new DialogueLine("Speaker 2", "And now I'm speaking."),
                new DialogueLine("Todd", "Buy Skyrim."),
                new DialogueSpriteSwitch(dialogueBackground, "check_mark")
            }
            );

        foreach (Sprite sprite in spriteLoader)
        {
            sprites.Add(sprite.name, sprite);
        }
    }
}
