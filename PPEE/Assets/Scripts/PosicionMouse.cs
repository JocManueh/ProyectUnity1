
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;


public class PosicionMouse : MonoBehaviour, IPointerClickHandler
{

    [System.Serializable]
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

    [Header("UI")]
    public Button botonExportar; 

    void Start()
    {
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
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, eventData.position, eventData.pressEventCamera, out localPoint))
        {
            lista.puntos.Add(new Punto(localPoint.x, localPoint.y));
            Debug.Log($"Punto guardado: {localPoint}");
        }
    }
    private void ExportarJSON()
    {
        string ruta = Path.Combine(Application.streamingAssetsPath, "puntos.json");
        string json = JsonUtility.ToJson(lista, true);
        File.WriteAllText(ruta, json);

        Debug.Log($"Archivo exportado en: {ruta}");
    }
}