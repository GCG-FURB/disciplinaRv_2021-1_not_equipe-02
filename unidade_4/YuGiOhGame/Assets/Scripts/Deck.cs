using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Deck : MonoBehaviour
{
    // espaços no tabuleiro
    public GameObject carta1_marrom;
    public GameObject carta2_marrom;
    public GameObject carta3_marrom;
    public GameObject carta4_marrom;
    public GameObject carta5_marrom;
    public GameObject carta1_verde;
    public GameObject carta2_verde;
    public GameObject carta3_verde;
    public GameObject carta4_verde;
    public GameObject carta5_verde;
    public GameObject deck_marrom;
    public GameObject deck_verde;

    // cartas cadastradas
    public GameObject assault_sentinel;
    public GameObject baby_dragon;
    public GameObject battlewasp;
    public GameObject big_eye;
    public GameObject blade_rabbit;
    public GameObject dark_bat;
    public GameObject dark_magician;
    public GameObject dark_magician_girl;
    public GameObject dark_summoning_beast;
    public GameObject evoltile_westlo;
    public GameObject fluffal_octopus;

    public Stack<GameObject> cartasDeck = new Stack<GameObject>(); // cartas cadastradas

    private Dictionary<string, Carta> cartas = new Dictionary<string, Carta>(); // carta + dados da carta


    // controle
    public bool isMarrom = true;
    public bool comprouUma = false;
    private int vidaMarrom = 4000;
    private int vidaVerde = 4000;
    private bool fimJogo = false;

    // carta comprada
    public GameObject cartaComprada;

    // cartas no jogo
    public GameObject[] cartasJogoMarrom = new GameObject[5] { null, null, null, null, null };
    public GameObject[] cartasJogoVerde = new GameObject[5] { null, null, null, null, null };

    void Start()
    {
        montaCartas();
    }

    private void montaCartas()
    {
        cartas.Add("assault_sentinel", new Carta(1600, 800));
        cartasDeck.Push(assault_sentinel);
        cartas.Add("baby_dragon", new Carta(1600, 800));
        cartasDeck.Push(baby_dragon);
        cartas.Add("battlewasp", new Carta(1000, 500));
        cartasDeck.Push(battlewasp);
        cartas.Add("big_eye", new Carta(1200, 1000));
        cartasDeck.Push(big_eye);
        cartas.Add("blade_rabbit", new Carta(400, 300));
        cartasDeck.Push(blade_rabbit);
        cartas.Add("dark_bat", new Carta(1000, 1000));
        cartasDeck.Push(dark_bat);
        cartas.Add("dark_magician", new Carta(2500, 2100));
        cartasDeck.Push(dark_magician);
        cartas.Add("dark_magician_girl", new Carta(2000, 1700));
        cartasDeck.Push(dark_magician_girl);
        cartas.Add("dark_summoning_beast", new Carta(0, 0));
        cartasDeck.Push(dark_summoning_beast);
        cartas.Add("evoltile_westlo", new Carta(700, 1900));
        cartasDeck.Push(evoltile_westlo);
        cartas.Add("fluffal_octopus", new Carta(800, 800));
        cartasDeck.Push(fluffal_octopus);

    }

    public void onClickDeckMarrom()
    {
        if (isMarrom && cartasDeck.Count > 0 && !fimJogo)
        {
            cartaComprada = Instantiate(cartasDeck.Pop(), new Vector3(0, 0, 0), Quaternion.identity);
            cartaComprada.transform.SetParent(GameObject.Find("deck_marrom").transform, false);
            cartaComprada.name = cartaComprada.name.Replace("(Clone)", "");
            comprouUma = true;
        }
    }

    public void onClickMarrom1()
    {
        if (isMarrom && cartaComprada != null)
        {
            cartasJogoMarrom[0] = cartaComprada;
            cartasJogoMarrom[0].transform.SetParent(GameObject.Find("carta1_marrom").transform, false);
            cartaComprada = null;
        }
    }

    public void onClickMarrom2()
    {
        if (isMarrom && cartaComprada != null)
        {
            cartasJogoMarrom[1] = cartaComprada;
            cartasJogoMarrom[1].transform.SetParent(GameObject.Find("carta2_marrom").transform, false);
            cartaComprada = null;
        }
    }

    public void onClickMarrom3()
    {
        if (isMarrom && cartaComprada != null)
        {
            cartasJogoMarrom[2] = cartaComprada;
            cartasJogoMarrom[2].transform.SetParent(GameObject.Find("carta3_marrom").transform, false);
            cartaComprada = null;
        }
    }

    public void onClickMarrom4()
    {
        if (isMarrom && cartaComprada != null)
        {
            cartasJogoMarrom[3] = cartaComprada;
            cartasJogoMarrom[3].transform.SetParent(GameObject.Find("carta4_marrom").transform, false);
            cartaComprada = null;
        }
    }

    public void onClickMarrom5()
    {
        if (isMarrom && cartaComprada != null)
        {
            cartasJogoMarrom[4] = cartaComprada;
            cartasJogoMarrom[4].transform.SetParent(GameObject.Find("carta5_marrom").transform, false);
            cartaComprada = null;
        }
    }

    public void onClickDeckVerde()
    {
        if (!isMarrom && cartasDeck.Count > 0 && !fimJogo)
        {
            cartaComprada = Instantiate(cartasDeck.Pop(), new Vector3(0, 0, 0), Quaternion.identity);
            cartaComprada.transform.SetParent(GameObject.Find("deck_verde").transform, false);
            cartaComprada.name = cartaComprada.name.Replace("(Clone)", "");
            comprouUma = true;
        }
    }

    public void onClickVerde1()
    {
        if (!isMarrom && cartaComprada != null)
        {
            cartasJogoVerde[0] = cartaComprada;
            cartasJogoVerde[0].transform.SetParent(GameObject.Find("carta1_verde").transform, false);
            cartaComprada = null;
        }
    }

    public void onClickVerde2()
    {
        if (!isMarrom && cartaComprada != null)
        {
            cartasJogoVerde[1] = cartaComprada;
            cartasJogoVerde[1].transform.SetParent(GameObject.Find("carta2_verde").transform, false);
            cartaComprada = null;
        }
    }

    public void onClickVerde3()
    {
        if (!isMarrom && cartaComprada != null)
        {
            cartasJogoVerde[2] = cartaComprada;
            cartasJogoVerde[2].transform.SetParent(GameObject.Find("carta3_verde").transform, false);
            cartaComprada = null;
        }
    }

    public void onClickVerde4()
    {
        if (!isMarrom && cartaComprada != null)
        {
            cartasJogoVerde[3] = cartaComprada;
            cartasJogoVerde[3].transform.SetParent(GameObject.Find("carta4_verde").transform, false);
            cartaComprada = null;
        }
    }

    public void onClickVerde5()
    {
        if (!isMarrom && cartaComprada != null)
        {
            cartasJogoVerde[4] = cartaComprada;
            cartasJogoVerde[4].transform.SetParent(GameObject.Find("carta5_verde").transform, false);
            cartaComprada = null;
        }
    }

    public void onClickDescartar()
    {
        if(cartaComprada)
        {
            cartaComprada.transform.SetParent(null);
            cartaComprada = null;
        }
    }

    public void onClickJogar()
    {
        if(fimJogo)
        {
            return;
        }

        bool ataqueVida = true;
        int somaAtaques = 0;
        int somaAtaquesVida = 0;
        Carta ataque = null;
        Carta defesa = null;

        if (isMarrom)
        {
            for(int i = 0; i < 5; i++)
            {
                if (cartasJogoMarrom[i] != null)
                {
                    if (cartasJogoVerde[i] != null)
                    {
                        ataqueVida = false;

                        ataque = cartas[cartasJogoMarrom[i].name];
                        defesa = cartas[cartasJogoVerde[i].name];

                        defesa.defesa -= ataque.ataque;

                        if(defesa.defesa < 0)
                        {
                            cartasJogoVerde[i].transform.SetParent(null);
                            cartasJogoVerde[i] = null;

                            somaAtaquesVida += defesa.defesa * (-1);

                        }
                    }
                    else
                    {
                        somaAtaques += cartas[cartasJogoMarrom[i].name].ataque;
                    }
                }
            }

            if (ataqueVida)
                vidaVerde -= somaAtaques;
            else
                vidaVerde -= somaAtaquesVida;

            GameObject.Find("VidaVerde").GetComponent<Text>().text = vidaVerde.ToString();

            if (vidaVerde <= 0)
            {
                fimJogo = true;
                GameObject.Find("Status").GetComponent<Text>().text = "Marrom ganhou!";
            }

        } 
        else
        {
            for (int i = 0; i < 5; i++)
            {
                if (cartasJogoVerde[i] != null)
                {
                    if (cartasJogoMarrom[i] != null)
                    {
                        ataqueVida = false;

                        ataque = cartas[cartasJogoVerde[i].name];
                        defesa = cartas[cartasJogoMarrom[i].name];

                        defesa.defesa -= ataque.ataque;

                        if (defesa.defesa < 0)
                        {
                            cartasJogoMarrom[i].transform.SetParent(null);
                            cartasJogoMarrom[i] = null;

                            somaAtaquesVida += defesa.defesa * (-1);

                        }
                    }
                    else
                    {
                        somaAtaques += cartas[cartasJogoVerde[i].name].ataque;
                    }
                }
            }

            if (ataqueVida)
                vidaMarrom -= somaAtaques;
            else
                vidaMarrom -= somaAtaquesVida;

            GameObject.Find("VidaMarrom").GetComponent<Text>().text = vidaMarrom.ToString();

            if(vidaMarrom <= 0)
            {
                fimJogo = true;
                GameObject.Find("Status").GetComponent<Text>().text = "Verde ganhou!";
            }
        }

        isMarrom = !isMarrom;
        comprouUma = false;
    }
}
