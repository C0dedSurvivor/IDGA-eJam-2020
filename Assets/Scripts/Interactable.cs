using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

class Interactable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Image spriteRenderer;
    [SerializeField]
    private string mouseOverSprite;
    [SerializeField]
    private string mouseLeaveSprite;

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
            spriteRenderer.sprite = GameStorage.sprites[mouseOverSprite];
    }

    /// <summary>
    /// Changes the sprite when the object is no longer moused over
    /// </summary>
    public void OnPointerExit(PointerEventData eventData)
    {
        spriteRenderer.sprite = GameStorage.sprites[mouseLeaveSprite];
    }

    public void InteractedWith()
    {
        used = true;
        spriteRenderer.sprite = GameStorage.sprites[mouseLeaveSprite];
    }
}
