using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public enum CardEffect
    {
        Damage,
        IfDamage,
        DamagePlusMovement,
        PlusDamageCard,
        Defense,
        DefensePlusType,
        Survived,
        Movement,
        CardDrow,
        AliveCardDrow,
        IfCardDrow,
        ResetCard,
        IfResetCard,
        Status,
        ManaAdd,
        Type,
        CheckDefenseStance,
        Mechanics,
        No
    }
    public enum TargetType
    {
        NoTarget,
        This,
        Enemy,
        Ally
    }
    public enum Stance
    {
        Defensive,
        Advance,
        Attacking,
        Raging
    }
    public enum CardType
    {
        Attack,
        Defense
    }
    public enum CharacterRestriction
    {
        Universal,
        Retiarius,
        Murmillo,
        Hoplomachus,
        Scissor
    }

    public CardEffect FirstCardEff, FirstCardEffTwo;
    public Stance StartStance, EndStance;
    public TargetType SpellTarget;
    public CardType Type;
    public CharacterRestriction Restriction;

    public string Name;
    public Sprite Logo;
    public int Manacost, SpellValue, SecondSpellValue;
    public bool IsPlaced;

    public Card(string name, string logoPath, int manacost, Stance startStance = 0, Stance endStance = 0, CardType type = 0,
        CardEffect firstCardEffect = 0, int spellValue = 0, CardEffect firstCardEffectTwo = 0, int secondSpellValue = 0,
        TargetType targetType = 0, CharacterRestriction restriction = CharacterRestriction.Universal)
    {
        Name = name;
        Logo = Resources.Load<Sprite>(logoPath);
        Manacost = manacost;
        IsPlaced = false;

        FirstCardEff = firstCardEffect;
        FirstCardEffTwo = firstCardEffectTwo;
        StartStance = startStance;
        EndStance = endStance;
        Type = type;
        Restriction = restriction;

        SpellTarget = targetType;
        SpellValue = spellValue;
        SecondSpellValue = secondSpellValue;

    }

    public Card(Card card)
    {
        Name = card.Name;
        Logo = card.Logo;
        Manacost = card.Manacost;
        IsPlaced = false;

        FirstCardEff = card.FirstCardEff;
        FirstCardEffTwo = card.FirstCardEffTwo;
        StartStance = card.StartStance;
        EndStance = card.EndStance;
        Type = card.Type;

        SpellTarget = card.SpellTarget;
        SpellValue = card.SpellValue;
        SecondSpellValue = card.SecondSpellValue;

    }

    public Card GetCopy()
    {
        return new Card(this);
    }

}

public static class CardManager
{
    public static List<Card> AllCards = new List<Card>();
}

public class ManagerCard : MonoBehaviour
{
    public void Awake()
    {
        //"��������"

        CardManager.AllCards.Add(new Card("������ ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 0, Card.CardEffect.Status, 0, Card.TargetType.Enemy, Card.CharacterRestriction.Retiarius));// ������ �� ������������
        CardManager.AllCards.Add(new Card("������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Advance, Card.CardType.Defense, Card.CardEffect.Defense, 3, Card.CardEffect.Movement, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Advance, Card.CardType.Defense, Card.CardEffect.Defense, 3, Card.CardEffect.Movement, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Advance, Card.CardType.Defense, Card.CardEffect.Defense, 3, Card.CardEffect.Movement, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Advance, Card.CardType.Defense, Card.CardEffect.Defense, 3, Card.CardEffect.Movement, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("����� � ������������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Defensive, Card.CardType.Attack, Card.CardEffect.Damage, 2, Card.CardEffect.Movement, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("����� � ������������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Defensive, Card.CardType.Attack, Card.CardEffect.Damage, 2, Card.CardEffect.Movement, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("���������� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 4, Card.CardEffect.ResetCard, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("���������� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 4, Card.CardEffect.ResetCard, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("���������� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Defensive, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.IfCardDrow, 1, Card.TargetType.Enemy));//����� ����� ������(���� ���)
        CardManager.AllCards.Add(new Card("���������� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Defensive, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.IfCardDrow, 1, Card.TargetType.Enemy));//����� ����� ������(���� ���)
        CardManager.AllCards.Add(new Card("����� ������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Movement, 1, Card.CardEffect.Damage, 2, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("����� ������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Movement, 1, Card.CardEffect.Damage, 2, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("����� ������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Movement, 1, Card.CardEffect.Damage, 2, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("��� �����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Defensive, Card.CardType.Defense, Card.CardEffect.Defense, 1, Card.CardEffect.Movement, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("��� �����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Defensive, Card.CardType.Defense, Card.CardEffect.Defense, 1, Card.CardEffect.Movement, 1, Card.TargetType.This));

        //������������� � ���� "�������"

        CardManager.AllCards.Add(new Card("�������� �����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Raging, Card.CardType.Attack, Card.CardEffect.Movement, 0, Card.CardEffect.IfDamage, 4, Card.TargetType.Enemy, Card.CharacterRestriction.Scissor));//����� �����
        CardManager.AllCards.Add(new Card("�������� �����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Raging, Card.CardType.Attack, Card.CardEffect.Movement, 0, Card.CardEffect.IfDamage, 4, Card.TargetType.Enemy, Card.CharacterRestriction.Scissor));//����� �����
        CardManager.AllCards.Add(new Card("�������� �����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Raging, Card.CardType.Attack, Card.CardEffect.Movement, 0 ,Card.CardEffect.IfDamage, 4, Card.TargetType.Enemy, Card.CharacterRestriction.Scissor));//����� �����
        CardManager.AllCards.Add(new Card("��������� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.CardDrow, 1, Card.TargetType.Enemy, Card.CharacterRestriction.Scissor));
        CardManager.AllCards.Add(new Card("��������� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.CardDrow, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("��������� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.CardDrow, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("��������� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.CardDrow, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("Rip and tear", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Raging, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.IfResetCard, 2, Card.CardEffect.Damage, 3, Card.TargetType.Enemy));//����� �����   
        CardManager.AllCards.Add(new Card("�������� �����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Raging, Card.Stance.Raging, Card.CardType.Attack, Card.CardEffect.Damage, 2, Card.CardEffect.ManaAdd, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("�������� ������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Raging, Card.CardType.Defense, Card.CardEffect.Defense, 0, Card.CardEffect.AliveCardDrow, 2, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("�������� ������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Raging, Card.CardType.Defense, Card.CardEffect.Defense, 0, Card.CardEffect.AliveCardDrow, 2, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("����������� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Advance, Card.CardType.Attack, Card.CardEffect.Damage, 4, Card.CardEffect.CardDrow, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("����������� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Advance, Card.CardType.Attack, Card.CardEffect.Damage, 4, Card.CardEffect.CardDrow, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("���� �������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.No, 0, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("���� �������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.No, 0, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("���� �������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.No, 0, Card.TargetType.Enemy));


        //������������� � ���� "���������"

        CardManager.AllCards.Add(new Card("��������� �����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.CheckDefenseStance, 0, Card.CardEffect.ResetCard, 2, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("��������� �����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.CheckDefenseStance, 0, Card.CardEffect.ResetCard, 2, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Defensive, Card.CardType.Defense, Card.CardEffect.Defense, 2, Card.CardEffect.Type, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Defensive, Card.CardType.Defense, Card.CardEffect.Defense, 2, Card.CardEffect.Type, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Defensive, Card.CardType.Defense, Card.CardEffect.Defense, 2, Card.CardEffect.Type, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Advance, Card.CardType.Defense, Card.CardEffect.Defense, 3, Card.CardEffect.Movement, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("����������� �����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Advance, Card.CardType.Attack, Card.CardEffect.PlusDamageCard, 2, Card.CardEffect.No, 0, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("����������� �����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Advance, Card.CardType.Attack, Card.CardEffect.PlusDamageCard, 2, Card.CardEffect.No, 0, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("������������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Defensive, Card.CardType.Attack, Card.CardEffect.DamagePlusMovement, 2, Card.CardEffect.CardDrow, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("������������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Defensive, Card.CardType.Attack, Card.CardEffect.DamagePlusMovement, 2, Card.CardEffect.CardDrow, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("���� �������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.No, 0, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("���� �������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.No, 0, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("����������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Defensive, Card.CardType.Defense, Card.CardEffect.DefensePlusType, 1, Card.CardEffect.CardDrow, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("����������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Defensive, Card.CardType.Defense, Card.CardEffect.DefensePlusType, 1, Card.CardEffect.CardDrow, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("��������� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.CardDrow, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("��������� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.CardDrow, 1, Card.TargetType.Enemy));


        //������������� � ���� "��������"

        CardManager.AllCards.Add(new Card("������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Advance, Card.CardType.Defense, Card.CardEffect.Defense, 3, Card.CardEffect.Movement, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Advance, Card.CardType.Defense, Card.CardEffect.Defense, 3, Card.CardEffect.Movement, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Defensive, Card.CardType.Defense, Card.CardEffect.DefensePlusType, 2, Card.CardEffect.No, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Defensive, Card.CardType.Defense, Card.CardEffect.DefensePlusType, 2, Card.CardEffect.No, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("���� ��-�� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.CardDrow, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("���� ��-�� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Defensive, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.CardDrow, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("����� ������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Movement, 1, Card.CardEffect.Damage, 2, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("����� ������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Movement, 2, Card.CardEffect.Damage, 2, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("����� ������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Movement, 2, Card.CardEffect.Damage, 2, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("����������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Defensive, Card.CardType.Defense, Card.CardEffect.DefensePlusType, 1, Card.CardEffect.CardDrow, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("����������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Advance, Card.Stance.Defensive, Card.CardType.Defense, Card.CardEffect.DefensePlusType, 1, Card.CardEffect.CardDrow, 1, Card.TargetType.This));
        CardManager.AllCards.Add(new Card("����� � ������������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Defensive, Card.CardType.Attack, Card.CardEffect.Damage, 2, Card.CardEffect.Movement, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("����� � ������������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Defensive, Card.CardType.Attack, Card.CardEffect.Damage, 2, Card.CardEffect.Movement, 1, Card.TargetType.Enemy));
        CardManager.AllCards.Add(new Card("���������� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Advance, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.IfCardDrow, 1, Card.TargetType.Enemy));//����� �����
        CardManager.AllCards.Add(new Card("���������� ����", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Advance, Card.CardType.Attack, Card.CardEffect.Damage, 3, Card.CardEffect.IfCardDrow, 1, Card.TargetType.Enemy));//����� �����
        CardManager.AllCards.Add(new Card("�������������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Movement, 1, Card.CardEffect.Damage, 4, Card.TargetType.Enemy, Card.CharacterRestriction.Hoplomachus));
        CardManager.AllCards.Add(new Card("�������������", "Sprites/LogoCards/CHto-to", 1, Card.Stance.Attacking, Card.Stance.Attacking, Card.CardType.Attack, Card.CardEffect.Movement, 1, Card.CardEffect.Damage, 4, Card.TargetType.Enemy, Card.CharacterRestriction.Hoplomachus));

    }
}
