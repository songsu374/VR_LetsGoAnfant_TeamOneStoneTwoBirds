using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.Extras;

public class DropObject : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    
    public MeshRenderer receivingRenderer;

    public Text scoreText;
    public int score;

    //public Color highlightColor = Color.yellow;

    //private Material rendererMat;
    //private Color normalColor;
    //private Texture droppedTexture;

#if UNITY_EDITOR
    private void Reset()
    {
        //laserPointer.PointerClick += PointerClick;
        score = 0;
        //receivingRenderer = GetComponentInChildren<MeshRenderer>();
    }
#endif

    public void OnEnable()
    {
        if (receivingRenderer != null)
        {
            //rendererMat = receivingRenderer.material;
            //normalColor = rendererMat.color;
            //receivingRenderer.sharedMaterial = rendererMat;
        }
    }

    void Start()
    {
        
    }

    public void PointerClick(object sender, PointerEventArgs eventArgs)
    {

        if (eventArgs.target.CompareTag("List1"))
        {

            //점수 125 증가
            score += 125;
            scoreText.text = "SCORE : " + score.ToString();

            eventArgs.target.gameObject.SetActive(false);

        }
       
    
    }

    public void OnDrop(PointerEventData data)
    {
        
    }

    public void OnPointerEnter(PointerEventData data)
    {
       
    }

    public void OnPointerExit(PointerEventData data)
    {
       
    }

    
}
