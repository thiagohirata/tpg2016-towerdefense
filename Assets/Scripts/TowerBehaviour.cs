using UnityEngine;
using System.Collections;

/// <summary>
/// Responsável por buscar um alvo e por controlar o cooldown. Não é o responsável pelo
/// ataque!
/// </summary>
public class TowerBehaviour : MonoBehaviour {
    public int enemyLayer;
    public Transform enemyTarget;
    public int reach;
    public const int NEARBY_ENEMIES_ALLOC = 2;
    public Collider[] nearbyEnemies = new Collider[NEARBY_ENEMIES_ALLOC];
    public int cooldownTime;
    public float currentCooldown;


    // Update is called once per frame
    void Update() {
        //Procura por inimigo
        int layerMask = 1 << enemyLayer; //ver https://docs.unity3d.com/Manual/Layers.html

        #region Busca target
        if (enemyTarget != null)
        {
            //já tenho um alvo - verificar se ele ainda está no alcance - 
            Collider enemyCollider = enemyTarget.GetComponent<Collider>();
            RaycastHit hit; //ignore
            if (!enemyCollider.Raycast(new Ray(this.transform.position, (enemyTarget.position - this.transform.position)), out hit, reach))
            {
                //mudou de target!!!
                enemyTarget = null;
            }
        }
        if (enemyTarget == null)
        {
            //Linha abaixo vai colocar em nearbyEnemies até NEARBY_ENEMIES_ALLOC (2) inimigos! Ver NonAlloc
            if (Physics.OverlapSphereNonAlloc(this.transform.position, this.reach, nearbyEnemies, layerMask) > 0)
            {
                enemyTarget = nearbyEnemies[0].transform;
            }
        } else
        {
            //faz torre "olhar" para o inimigo
            this.transform.LookAt(enemyTarget.transform);
        }
        #endregion

        #region Controla cooldown
        if (currentCooldown > 0)
        {
            currentCooldown -= Time.deltaTime;
            if (currentCooldown < 0 || currentCooldown == 0)
            {
                this.SendMessage("EndCooldown", SendMessageOptions.DontRequireReceiver);
                currentCooldown = 0;
            }
        }
        #endregion

        #region Envia mensagem de ataque - outro componente é o responsável!
        if (enemyTarget != null && currentCooldown == 0)
        {
            currentCooldown = cooldownTime;
            //algum behaviour deste componente precisa ficar ouvindo a mensagem Attack
            //para esta torre fazer alguma coisa
            this.SendMessage("Attack", enemyTarget, SendMessageOptions.DontRequireReceiver);
        }
        #endregion

    }

    /// <summary>
    /// Ver https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnDrawGizmos.html
    /// </summary>
    void OnDrawGizmos() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(this.transform.position, this.reach);
        if(enemyTarget != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(this.transform.position, enemyTarget.position);
        }
    }
}
