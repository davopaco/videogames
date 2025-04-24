using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite resumeSprite;
    public Sprite pauseSprite;

    public void Resume()
    {
        if (spriteRenderer != null && resumeSprite != null)
        {
            spriteRenderer.sprite = resumeSprite;
        }
    }

    public void Pause()
    {
        if (spriteRenderer != null && pauseSprite != null)
        {
            spriteRenderer.sprite = pauseSprite;
        }
    }
}
