using UnityEngine;

public class Enemy:MonoBehaviour
{
    public string nome;
    public float speed;
    public float vida;
    public float vidMax;
    public Transform Target;

    void Start()
    {
        vida = vidMax;
        introduction();
    }
    void introduction()
    {
        Debug.Log("sou" + nome);
    }

    void move()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);
    }

    private void Update()
    {
        move();
    }

}

