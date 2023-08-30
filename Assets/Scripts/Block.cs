using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Block : MonoBehaviour
{
    
    public static Block Instance {get; private set;}
    void Awake(){
        Instance = this;
    }
    [SerializeField] public int health;
    private BoxCollider2D bc;
    private TextMeshPro text;
    // Update is called once per frame
    private void Start()
    {
        text = gameObject.transform.GetChild(0).GetComponent<TextMeshPro>();
        text.text = health + "";
    }
    // public IEnumerator MoveBlock(){
    //         transform.Translate(Vector3.down*1f);
    //         yield return 1;
    // }
    // public void Update(){
    //      if((BallSpawner.Instance.BallCount()==0)&&(BallSpawner.Instance.isStart==1)){
    //         StartCoroutine(MoveBlock());
    //      }

    // }
   
    private void OnCollisionEnter2D(Collision2D collison)
    {
        if (!collison.gameObject.CompareTag("Ball")) return;
        if (health > 0)
        {
            health--;
            text.text = health + "";
            GameManager.Instance.UpdateScores(1);
           
        }

        if (health == 0)
        {
            Destroy(gameObject);
            GameManager.Instance.UpdateBlockCount(1);
           
        }
    }
    
}
