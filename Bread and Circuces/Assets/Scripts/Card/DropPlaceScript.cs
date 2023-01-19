using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum FieldType
{
    SelfHand,
    Field,
    DiscardingPlayerCards,
    DiscardingEnemyCards,
    PlayerLastCardCast,
    PlayerLastCardInfo,
    EnemyLastCardCast,
    EnemyLastCardInfo,
}
public class DropPlaceScript : MonoBehaviour, IDropHandler
{
    public FieldType Type;
    public void OnDrop(PointerEventData eventData)
    {
        CardController card = eventData.pointerDrag.GetComponent<CardController>();

        if (card.gameObject.GetComponent<CardMovementScript>().canBePlayed)
            card.OnCast();
    }
}
