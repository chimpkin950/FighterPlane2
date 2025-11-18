using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public GameObject explosionPrefab;
    private GameManager gameManager;
    // Start is called before the first frame update
 
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    
    void Update()
    {
        // transform.Translate(Vector3. down * Time.deltaTime * 8f);
        transform.Translate(new Vector3(1, -2, 0) * Time.deltaTime * 2f);
        if (transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D whatDidIHit)
    {
        Debug.Log("Enemy hit: " + whatDidIHit.gameObject.name);
        if (whatDidIHit.tag == "Player")
        {
            whatDidIHit.GetComponent<PlayerController>().LoseALife();
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
        else if (whatDidIHit.tag == "Weapons")
        {
            Destroy(whatDidIHit.gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            gameManager.AddScore(5);
            Destroy(this.gameObject);
        }
    }
}