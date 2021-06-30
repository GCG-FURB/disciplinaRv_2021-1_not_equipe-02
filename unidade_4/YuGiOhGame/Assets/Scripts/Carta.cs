using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour
{
    public int ataque;
    public int defesa;

    public Carta(int ataque, int defesa)
    {
        this.ataque = ataque;
        this.defesa = defesa;
    }
}
