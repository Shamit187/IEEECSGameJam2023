using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLife : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject MainCharacter;
    PlayerLife playerLife;
    [SerializeField] float BaseBar;
    SpriteRenderer mySpriteRenderer;
    void Start()
    {
        playerLife = MainCharacter.GetComponent<PlayerLife>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale =new Vector3(BaseBar * playerLife.Life, transform.localScale.y, transform.localScale.z);
        if(playerLife.Life > 0) mySpriteRenderer.color = new Color(0, 1, 0, 1);
        else mySpriteRenderer.color = new Color(1, 0, 0, 1);
    }
}
