using UnityEngine;
using System.Collections.Generic;

public class WaveReaderBehaviour : MonoBehaviour {
    public Wave myWave;
    public Queue<WaveStep> steps;
    private WaveStep currentStep;
    public float currentStepTime;
    public Transform goal;
    

	void Start () {
	    if(myWave == null)
        {
            //não habilitar se não existir Wave configurada
            this.enabled = false;
        } else
        {
            this.steps = new Queue<WaveStep>(myWave.steps);
            this.currentStep = steps.Dequeue();
        }
    }
	
	
	void FixedUpdate () {
	    if(currentStep == null)
        {
            if(steps.Count > 0) {
                currentStep = steps.Dequeue();
                currentStepTime = 0;
            }
        } else
        {
            currentStepTime += Time.fixedDeltaTime;
        }

        if(currentStep != null && currentStepTime > currentStep.pause)
        {
            try
            {
                Vector3 pos = this.transform.position;
                Quaternion rot = this.transform.rotation;
                GameObject inimigoCriado = (GameObject)Instantiate(currentStep.prefab, pos, rot);
                inimigoCriado.GetComponent<NavmeshWalker>().goal = this.goal;
            }
            finally
            {
                //zera o step atual - vai buscar da fila steps no próximo FixedUpdate
                currentStep = null;
            }
        }

	}
}
