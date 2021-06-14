using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody RB; //declarar o rigidbody
    public float moveSpeed, jumpForce; //variaveis de velocidade de movimento e salto

    private Vector2 moveInput; // controlos do personagem 
    
    public Animator anim; //animações do personagem "sprite"

    public LayerMask whatIsGround; //Procura por todas as Layer chamadas "ground"
    public Transform groundPoint; //Check point do "ground"
    private bool isGrounded; 

    public SpriteRenderer SR; //Render das Animações do sprite

    private bool movingBackwards;

    public Animator flipAnim; //animações do personagem "player"

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal"); //input dos comandos x
        moveInput.y = Input.GetAxis("Vertical"); //input dos comandos y
        

        RB.velocity = new Vector3(moveInput.x * moveSpeed, RB.velocity.y, moveInput.y * moveSpeed);
        //movimento do personagem em x e y
        anim.SetFloat("moveSpeed", RB.velocity.magnitude);
        //animação do sprite a andar 
        RaycastHit hit;
        if (Physics.Raycast(groundPoint.position, Vector3.down, out hit, .3f, whatIsGround))//set do chão
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        if (Input.GetKey("space") && isGrounded)//comando para saltar
        {
            RB.velocity += new Vector3(0f, jumpForce, 0f);
        }
        //salto do personagem
        anim.SetBool("onGround", isGrounded);
        //animação de sprite do salto

        if (!movingBackwards && moveInput.y > 0)
        {
            movingBackwards = true;
        }
        else if (movingBackwards && moveInput.y < 0)
        {
            movingBackwards = false;
        }
        anim.SetBool("movingBackwards", movingBackwards); //animaçoes de traz
    }

    }