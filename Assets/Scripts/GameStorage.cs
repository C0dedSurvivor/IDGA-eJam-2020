using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

class GameStorage : MonoBehaviour
{
    public static Dictionary<string, List<DialogueNode>> interactableDialogues = new Dictionary<string, List<DialogueNode>>();
    public static Dictionary<string, Sprite> sprites = new Dictionary<string, Sprite>();

    //A serialized list of sprites to assist in loading in necessary images for quick-swapping
    [SerializeField]
    private List<Sprite> spriteLoader = new List<Sprite>();

    [SerializeField]
    private Image dialogueBackground;

    void Start()
    {
        interactableDialogues.Add(
            "test interactable", new List<DialogueNode>()
            {
                new DialogueLine("Speaker 1", "Hi, I'm speaking now."),
                new DialogueLine("Speaker 2", "And now I'm speaking."),
                new DialogueLine("Todd", "Buy Skyrim."),
                new DialogueSpriteSwitch(dialogueBackground, "check_mark"),
                new DialogueLine("Todd", "Press the T key to continue.", KeyCode.T),
                new DialogueLine("Todd", "Good, good."),
                new DialogueLine("Todd", "Let's get rid of that check mark."),
                new DialogueHideObject(dialogueBackground.gameObject),
                new DialogueLine("Todd", "Nevermind, I think I just needed to move it."),
                new DialogueMoveObject(dialogueBackground.gameObject, new Vector3(300, 300)),
                new DialogueShowObject(dialogueBackground.gameObject),
                new DialogueLine("Todd", "That's better."),
            }
            );

        switch (SceneManager.GetActiveScene().name)
        {
            case "Room1":
                interactableDialogues.Add(
                    "room1Start", 
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "Hi, I'm Productivity! I'm the part of you that makes sure you get done what needs to be done."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "And I'm Passion! I'm the one that makes sure you have some fun and do what you like to do!"),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "We can sometimes be at odds about how you should be using your time..."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "Yea, this poopy head keeps trying to get you to do all the boring stuff!"),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "Well Passion, we kind of need money to live."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "Money shmoney, who needs it if your heart's not in what you're doing!"),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "Well, if you want to live in a nice house and not be stuck with your parents you need to sit down and earn money through work."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "But is this where you belong? Stuck cooped up in an office? If you have a creative idea in mind you have to work on it now, or else you might not get the chance   to!"),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "This is what you’re doing right here, right now. If it becomes a problem, you can change it later, after you’ve ensured you don’t fall behind your peers."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "Your projects are important to you though, and you enjoy working on them. It’s important to stay happy."),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "Well why don't we let them decide. Look around to see what we each have to say on the matter."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room1Calendar",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "You have deadlines to reach and limited time to reach them. You need to keep working to get it done in time."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room1Binder",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "Plan out your future, you don’t want to be left aimless."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room1Coffee",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "Your co-workers and your connections are key to staying successful."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room1Butterflies",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "It doesn't matter how good you are now. Start small, you’ll improve as you go!"),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room1Friends",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "Your friends are key to staying sane and happy. Make time for them or you'll lose them!"),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room1Canvas",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "Always be willing to try something new, you never know when you’ll find something you really enjoy!"),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room1End",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "I guess we're both needed in a way."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "Yea, as much as I hate to admit it you do kinda need money to do your hobbies..."),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "And while earning it is great you do need to make time to do what you love and destress or you might just implode."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "It's a balancing act!"),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "Yes! Making time to listen to both of us is very difficult but important. I'm sure you can do it, though."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "We shall see, won't we! Remember, persistence is key!"),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                break;
        }

        foreach (Sprite sprite in spriteLoader)
        {
            sprites.Add(sprite.name, sprite);
        }
    }
}
