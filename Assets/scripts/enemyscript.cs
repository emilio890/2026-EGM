using Unity.VisualScripting;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
 Rigidbody2D rbenemy;
    [SerializeField]
    private managerscript Gamemanager;

    void Start()
    {
        rbenemy = GetComponent<Rigidbody2D>();
        rbenemy.AddForce(Vector2.down * 100);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Gamemanager.addscore();
            Destroy(this.gameObject);

        }
    }
}

