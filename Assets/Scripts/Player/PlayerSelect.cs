using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    private enum Player { Frog, VirtualGuy, PinkMan, MaskDude };
    [SerializeField] private bool enableSelectedCharacter;
    [SerializeField] private Player playerSelected;
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private RuntimeAnimatorController[] playerController;
    [SerializeField] private Sprite[] playersRenderer;

    void Start()
    {
        if (!enableSelectedCharacter)
        {
            ChangePlayerInPanelMenu();
        }
        else
        {
            ChangeCharacterInUnityMenu();
        }
    }

    public void ChangePlayerInPanelMenu()
    {
        switch (PlayerPrefs.GetString("PlayerSelected"))
        {
            case "Frog":
                spriteRenderer.sprite = playersRenderer[0];
                animator.runtimeAnimatorController = playerController[0];
                break;
            case "PinkMan":
                spriteRenderer.sprite = playersRenderer[1];
                animator.runtimeAnimatorController = playerController[1];
                break;
            case "VirtualGuy":
                spriteRenderer.sprite = playersRenderer[2];
                animator.runtimeAnimatorController = playerController[2];
                break;
            case "MaskDude":
                spriteRenderer.sprite = playersRenderer[3];
                animator.runtimeAnimatorController = playerController[3];
                break;
            default:
                break;
        }
    }

    private void ChangeCharacterInUnityMenu()
    {
        switch (playerSelected)
        {
            case Player.Frog:
                spriteRenderer.sprite = playersRenderer[0];
                animator.runtimeAnimatorController = playerController[0];
                break;
            case Player.PinkMan:
                spriteRenderer.sprite = playersRenderer[1];
                animator.runtimeAnimatorController = playerController[1];
                break;
            case Player.VirtualGuy:
                spriteRenderer.sprite = playersRenderer[2];
                animator.runtimeAnimatorController = playerController[2];
                break;
            case Player.MaskDude:
                spriteRenderer.sprite = playersRenderer[3];
                animator.runtimeAnimatorController = playerController[3];
                break;
            default:
                break;
        }
    }

}
