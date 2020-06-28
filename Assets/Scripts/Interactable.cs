using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

class Interactable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Image spriteRenderer;
    [SerializeField]
    private Sprite mouseOverSprite;
    [SerializeField]
    private Sprite mouseLeaveSprite;

    //Whether this interactable has been triggered
    private bool used = false;

    /// <summary>
    /// Grab this object's sprite renderer
    /// </summary>
    void Start()
    {
        spriteRenderer = GetComponent<Image>();
    }

    /// <summary>
    /// Changes the sprite when the object is moused over
    /// </summary>
    public void OnPointerEnter(PointerEventData eventData)
    {
        if(!used)
            spriteRenderer.sprite = mouseOverSprite;
    }

    /// <summary>
    /// Changes the sprite when the object is no longer moused over
    /// </summary>
    public void OnPointerExit(PointerEventData eventData)
    {
        spriteRenderer.sprite = mouseLeaveSprite;
    }

    public void InteractedWith()
    {
        used = true;
        spriteRenderer.sprite = mouseLeaveSprite;
        GetComponent<Button>().interactable = false;
    }
}
