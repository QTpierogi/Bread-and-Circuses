using System.Collections.Generic;
using UnityEngine;

namespace Card
{
    public static class CardManager
    {
        public static List<Card> AllCards = new List<Card>();
    }

    public class ManagerCard : MonoBehaviour
    {
        public void Awake()
        {
            if (CardManager.AllCards.Count != 0)
                return;

            //"��������"

            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "������ ����",
                "Sprites/LogoCards/����������", 1, Stance.Defensive, Stance.Attacking, EnumCard.CardType.Defense,
                EnumCard.CardEffect.Defense, 15,
                EnumCard.CardEffect.CancelCard, 0, EnumCard.TargetType.Enemy, "�������� ��� ������� ��������� �����",
                EnumCard.CardRestriction.Retiarius)); // ������ �� ������������
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "������", "Sprites/LogoCards/������",
                0,
                Stance.Defensive, Stance.Advance, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 3,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "������", "Sprites/LogoCards/������",
                0,
                Stance.Defensive, Stance.Advance, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 3,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "����������",
                "Sprites/LogoCards/����������", 1,
                Stance.Defensive, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "����������",
                "Sprites/LogoCards/����������", 1,
                Stance.Defensive, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "����� � ��������",
                "Sprites/LogoCards/��������������", 1, Stance.Attacking, Stance.Defensive, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.Enemy,
                "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "����� � ��������",
                "Sprites/LogoCards/��������������", 1, Stance.Attacking, Stance.Defensive, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.Enemy,
                "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "���������� ����",
                "Sprites/LogoCards/��������������", 1, Stance.Attacking, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 4, EnumCard.CardEffect.DiscardEnemy, 1, EnumCard.TargetType.Enemy,
                "���� ������ �������� ���� ����� � ���� �� �����", EnumCard.CardRestriction.Retiarius));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "���������� ����",
                "Sprites/LogoCards/��������������", 1, Stance.Attacking, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 4, EnumCard.CardEffect.DiscardEnemy, 1, EnumCard.TargetType.Enemy,
                "���� ������ �������� ���� ����� � ���� �� �����", EnumCard.CardRestriction.Retiarius));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "���������� ����",
                "Sprites/LogoCards/��������������", 1, Stance.Attacking, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.NearCardDrow, 1, EnumCard.TargetType.Enemy,
                "���� �� �������� ������ ��� �����, �������� �����")); //����� �����
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "���������� ����",
                "Sprites/LogoCards/��������������", 1, Stance.Attacking, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.NearCardDrow, 1, EnumCard.TargetType.Enemy,
                "���� �� �������� ������ ��� �����, �������� �����")); //����� �����
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "����� ������",
                "Sprites/LogoCards/����������", 1,
                Stance.Advance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Movement, 1,
                EnumCard.CardEffect.Damage,
                2, EnumCard.TargetType.Enemy, "����� ������ ����������� ����� ����� �� ���� ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "����� ������",
                "Sprites/LogoCards/����������", 1,
                Stance.Advance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Movement, 1,
                EnumCard.CardEffect.Damage,
                2, EnumCard.TargetType.Enemy, "����� ������ ����������� ����� ����� �� ���� ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "����� ������",
                "Sprites/LogoCards/����������", 1,
                Stance.Advance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Movement, 1,
                EnumCard.CardEffect.Damage,
                2, EnumCard.TargetType.Enemy, "����� ������ ����������� ����� ����� �� ���� ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "��� �����",
                "Sprites/LogoCards/��������", 0,
                Stance.Advance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 1,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "��� �����",
                "Sprites/LogoCards/��������", 0,
                Stance.Advance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 1,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));

            //������������� � ���� "�������"

            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "�������� �����",
                "Sprites/LogoCards/�������������",
                1, Stance.Advance, Stance.Raging, EnumCard.CardType.Attack, EnumCard.CardEffect.ChargeStart, 4,
                EnumCard.CardEffect.ChargeEnd, 4, EnumCard.TargetType.Enemy,
                "����� ������ ����������� ����� ����� �� ���������� �� 4 ������. -1 ���� �� ������ ���������� ����",
                EnumCard.CardRestriction.Scissor)); //����� �����
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "�������� �����",
                "Sprites/LogoCards/�������������",
                1, Stance.Advance, Stance.Raging, EnumCard.CardType.Attack, EnumCard.CardEffect.ChargeStart, 4,
                EnumCard.CardEffect.ChargeEnd, 4, EnumCard.TargetType.Enemy,
                "����� ������ ����������� ����� ����� �� ���������� �� 4 ������. -1 ���� �� ������ ���������� ����",
                EnumCard.CardRestriction.Scissor)); //����� �����
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "�������� �����",
                "Sprites/LogoCards/�������������",
                1, Stance.Advance, Stance.Raging, EnumCard.CardType.Attack, EnumCard.CardEffect.ChargeStart, 4,
                EnumCard.CardEffect.ChargeEnd, 4, EnumCard.TargetType.Enemy,
                "����� ������ ����������� ����� ����� �� ���������� �� 4 ������. -1 ���� ��  ������ ���������� ����",
                EnumCard.CardRestriction.Scissor)); //����� �����
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "��������� ����",
                "Sprites/LogoCards/�������������",
                1, Stance.Advance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "��������� ����",
                "Sprites/LogoCards/�������������",
                1, Stance.Advance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "��������� ����",
                "Sprites/LogoCards/�������������",
                1, Stance.Advance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "Rip and tear",
                "Sprites/LogoCards/RipAndTear", 1,
                Stance.Raging, Stance.Advance, EnumCard.CardType.Attack, EnumCard.CardEffect.DiscardSelf, 2,
                EnumCard.CardEffect.DamageAfterDiscard, 3, EnumCard.TargetType.Enemy,
                "����� ������ �������� �� ���� ����. +2 � ����� �� ������ ���������� �����",
                EnumCard.CardRestriction.Scissor)); //����� �����   
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "�������� �����",
                "Sprites/LogoCards/�������������",
                1, Stance.Raging, Stance.Raging, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 2,
                EnumCard.CardEffect.ManaAdd,
                1, EnumCard.TargetType.Enemy, "�������� 1 ���� ��������", EnumCard.CardRestriction.Scissor));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "�������� ������",
                "Sprites/LogoCards/��������������", 0, Stance.Attacking, Stance.Raging, EnumCard.CardType.Defense,
                EnumCard.CardEffect.Defense, 0, EnumCard.CardEffect.AliveCardDrow, 2, EnumCard.TargetType.This,
                "���� ���� ���� �����, �������� 2 �����", EnumCard.CardRestriction.Scissor));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "�������� ������",
                "Sprites/LogoCards/��������������", 0, Stance.Attacking, Stance.Raging, EnumCard.CardType.Defense,
                EnumCard.CardEffect.Defense, 0, EnumCard.CardEffect.AliveCardDrow, 2, EnumCard.TargetType.This,
                "���� ���� ���� �����, �������� 2 �����", EnumCard.CardRestriction.Scissor));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "����������� ����",
                "Sprites/LogoCards/���������������", 1, Stance.Attacking, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 4, EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����",
                EnumCard.CardRestriction.Scissor));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "����������� ����",
                "Sprites/LogoCards/���������������", 1, Stance.Attacking, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 4, EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����",
                EnumCard.CardRestriction.Scissor));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "���� �������",
                "Sprites/LogoCards/�����������", 1,
                Stance.Attacking, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.No,
                0,
                EnumCard.TargetType.Enemy));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "���� �������",
                "Sprites/LogoCards/�����������", 1,
                Stance.Attacking, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.No,
                0,
                EnumCard.TargetType.Enemy));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "���� �������",
                "Sprites/LogoCards/�����������", 1,
                Stance.Attacking, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.No,
                0,
                EnumCard.TargetType.Enemy));


            //������������� � ���� "���������"

            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "��������� �����",
                "Sprites/LogoCards/��������������", 1, Stance.Defensive, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 0, EnumCard.CardEffect.Stun, 2, EnumCard.TargetType.Enemy,
                "������� ������ ���� �� ���������. ��������� ������ �������� ��� �����",
                EnumCard.CardRestriction.Murmillo));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "��������� �����",
                "Sprites/LogoCards/��������������", 1, Stance.Defensive, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 0, EnumCard.CardEffect.Stun, 2, EnumCard.TargetType.Enemy,
                "������� ������ ���� �� ���������. ��������� ������ �������� ��� �����",
                EnumCard.CardRestriction.Murmillo));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "����", "Sprites/LogoCards/����", 0,
                Stance.Defensive, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 2,
                EnumCard.CardEffect.No, 0, EnumCard.TargetType.This, "+1 � ������, ���� ���� ���� �������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "����", "Sprites/LogoCards/����", 0,
                Stance.Defensive, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 2,
                EnumCard.CardEffect.No, 0, EnumCard.TargetType.This, "+1 � ������, ���� ���� ���� �������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "����", "Sprites/LogoCards/����", 0,
                Stance.Defensive, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 2,
                EnumCard.CardEffect.No, 0, EnumCard.TargetType.This, "+1 � ������, ���� ���� ���� �������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "������", "Sprites/LogoCards/������",
                0,
                Stance.Defensive, Stance.Advance, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 3,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "����������� �����",
                "Sprites/LogoCards/����������������", 1, Stance.Attacking, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.DamageFinisher, 2, EnumCard.CardEffect.No, 0, EnumCard.TargetType.Enemy,
                "+1 � ����� �� ������ �����, ����������� � ��� ���������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "����������� �����",
                "Sprites/LogoCards/����������������", 1, Stance.Attacking, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.DamageFinisher, 2, EnumCard.CardEffect.No, 0, EnumCard.TargetType.Enemy,
                "+1 � ����� �� ������ �����, ����������� � ��� ���������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "������������",
                "Sprites/LogoCards/������������", 1,
                Stance.Attacking, Stance.Defensive, EnumCard.CardType.Attack, EnumCard.CardEffect.PushBackEnemy, 1,
                EnumCard.CardEffect.CardDrow, 2, EnumCard.TargetType.Enemy, "����������� ����� �� 1 ����. �������� 2 �����",
                EnumCard.CardRestriction.Murmillo));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "������������",
                "Sprites/LogoCards/������������", 1,
                Stance.Attacking, Stance.Defensive, EnumCard.CardType.Attack, EnumCard.CardEffect.PushBackEnemy, 1,
                EnumCard.CardEffect.CardDrow, 2, EnumCard.TargetType.Enemy, "����������� ����� �� 1 ����. �������� 2 �����",
                EnumCard.CardRestriction.Murmillo));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "���� �������",
                "Sprites/LogoCards/�����������", 1,
                Stance.Attacking, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.No,
                0,
                EnumCard.TargetType.Enemy));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "���� �������",
                "Sprites/LogoCards/�����������", 1,
                Stance.Attacking, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.No,
                0,
                EnumCard.TargetType.Enemy));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "����������",
                "Sprites/LogoCards/����������", 0,
                Stance.Advance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 1,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.This,
                "+1 � ������, ���� ���� ���� �������. �������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "����������",
                "Sprites/LogoCards/����������", 0,
                Stance.Advance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 1,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.This,
                "+1 � ������, ���� ���� ���� �������. �������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "��������� ����",
                "Sprites/LogoCards/�������������",
                1, Stance.Advance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "��������� ����",
                "Sprites/LogoCards/�������������",
                1, Stance.Advance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����"));


            //������������� � ���� "��������"

            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "������",
                "Sprites/LogoCards/������", 0,
                Stance.Defensive, Stance.Advance, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 3,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "������",
                "Sprites/LogoCards/������", 0,
                Stance.Defensive, Stance.Advance, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 3,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����", "Sprites/LogoCards/����", 0,
                Stance.Defensive, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 2,
                EnumCard.CardEffect.No, 1, EnumCard.TargetType.This, "+1 � ������, ���� ���� ���� �������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����", "Sprites/LogoCards/����", 0,
                Stance.Defensive, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 2,
                EnumCard.CardEffect.No, 1, EnumCard.TargetType.This, "+1 � ������, ���� ���� ���� �������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����������",
                "Sprites/LogoCards/����������", 1,
                Stance.Defensive, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����������",
                "Sprites/LogoCards/����������", 1,
                Stance.Defensive, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����� ������",
                "Sprites/LogoCards/����������",
                1, Stance.Advance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Movement, 1,
                EnumCard.CardEffect.Damage, 2, EnumCard.TargetType.Enemy, "����� ������ ����������� ����� ����� �� ���� ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����� ������",
                "Sprites/LogoCards/����������",
                1, Stance.Advance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Movement, 1,
                EnumCard.CardEffect.Damage, 2, EnumCard.TargetType.Enemy, "����� ������ ����������� ����� ����� �� ���� ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����� ������",
                "Sprites/LogoCards/����������",
                1, Stance.Advance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Movement, 1,
                EnumCard.CardEffect.Damage, 2, EnumCard.TargetType.Enemy, "����� ������ ����������� ����� ����� �� ���� ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����������",
                "Sprites/LogoCards/����������", 0,
                Stance.Advance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 1,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.This,
                "+1 � ������, ���� ���� ���� �������. �������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����������",
                "Sprites/LogoCards/����������", 0,
                Stance.Advance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 1,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.This,
                "+1 � ������, ���� ���� ���� �������. �������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����� � ��������",
                "Sprites/LogoCards/��������������", 1, Stance.Attacking, Stance.Defensive, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.Enemy,
                "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����� � ��������",
                "Sprites/LogoCards/��������������", 1, Stance.Attacking, Stance.Defensive, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.Enemy,
                "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "���������� ����",
                "Sprites/LogoCards/��������������", 1, Stance.Attacking, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.NearCardDrow, 1, EnumCard.TargetType.Enemy,
                "���� �� �������� ������ ��� �����, �������� �����")); //����� �����
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "���������� ����",
                "Sprites/LogoCards/��������������", 1, Stance.Attacking, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.NearCardDrow, 1, EnumCard.TargetType.Enemy,
                "���� �� �������� ������ ��� �����, �������� �����")); //����� �����
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "�������������",
                "Sprites/LogoCards/�������������", 1, Stance.Attacking, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Movement, 1, EnumCard.CardEffect.Damage, 4, EnumCard.TargetType.Enemy,
                "����� ������ ����������� ����� ����� �� ���� ����", EnumCard.CardRestriction.Hoplomachus));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "�������������",
                "Sprites/LogoCards/�������������", 1, Stance.Attacking, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Movement, 1, EnumCard.CardEffect.Damage, 4, EnumCard.TargetType.Enemy,
                "����� ������ ����������� ����� ����� �� ���� ����", EnumCard.CardRestriction.Hoplomachus));
        }
    }
}