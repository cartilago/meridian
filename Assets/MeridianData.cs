﻿using UnityEngine;
using System.Collections;

public class MeridianData
{
    [System.Serializable]
    public class Store
    {
        public int ID;
        public string Tienda;
        public string Cadena;
        public string Latitud;
        public string Longitud;
        public string Determinante;

        public Vector2 coordinates
        {
            get
            {
                return new Vector2(float.Parse(Longitud), float.Parse(Latitud));
            }
        }
    }

    [System.Serializable]
    public class Stores
    {
        public Store[] storeList;
    }
}
