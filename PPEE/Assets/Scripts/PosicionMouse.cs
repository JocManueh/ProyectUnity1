
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;
using PuntosXY;
using System;


public class PosicionMouse : MonoBehaviour
{

    [Serializable]
    public class Punto
    {
        public double x;
        public double y;

        public Punto(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
    [System.Serializable]
    private class ListaDePuntos
    {
        public List<Punto> puntos = new List<Punto>();
    }

    private ListaDePuntos lista = new ListaDePuntos();
    private RectTransform rectTransform;


    [Header("UI")]
    public Button botonExportar; 

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        if (botonExportar != null)
            botonExportar.onClick.AddListener(ExportarJSON);

        string carpeta = Application.streamingAssetsPath;
        if (!Directory.Exists(carpeta))
        {
            Directory.CreateDirectory(carpeta);
            Debug.Log("Carpeta StreamingAssets creada en: " + carpeta);
        }
    }




    public void OnPointerClick(PointerEventData eventData)
    {
        RectTransform rectTransform = GetComponent<RectTransform>();

        Vector2 localPoint;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform,Input.mousePosition,null, out localPoint))
        {
            if (rectTransform.rect.Contains(localPoint))
            {


                lista.puntos.Add(new Punto(localPoint.x, localPoint.y));
                Debug.Log("Punto guardado: {localPoint}");
            }
        }
    }
    private void ExportarJSON()
    {
        string ruta = Path.Combine(Application.streamingAssetsPath, "puntos.json");
        string json = JsonUtility.ToJson(lista, true);
        File.WriteAllText(ruta, json);
        Debug.Log("Archivo exportado en: {ruta}");
    }


}