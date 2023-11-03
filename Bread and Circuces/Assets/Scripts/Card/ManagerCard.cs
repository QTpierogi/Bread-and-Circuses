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
            var defAttStance = new List<Stance>() { Stance.Defensive, Stance.Attacking };
            var defAdvStance = new List<Stance>() { Stance.Defensive, Stance.Advance };
            var advAttStance = new List<Stance>() { Stance.Attacking, Stance.Advance };
            var defStance = new List<Stance>() { Stance.Defensive };
            var attStance = new List<Stance>() { Stance.Attacking };
            var advStance = new List<Stance> { Stance.Advance };
            var anyStance = new List<Stance>() { Stance.Defensive, Stance.Advance, Stance.Attacking };
            var rageStance = new List<Stance>() { Stance.Raging };

            //"��������"

            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "������ ����",
                "Sprites/LogoCards/����������", 1, anyStance, Stance.Attacking, EnumCard.CardType.Defense,
                EnumCard.CardEffect.Defense, 15,
                EnumCard.CardEffect.CancelCard, 0, EnumCard.TargetType.Enemy, "�������� ��� ������� ��������� �����",
                EnumCard.CardRestriction.Retiarius)); // ������ �� ������������
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "������", "Sprites/LogoCards/������",
                0,
                defStance, Stance.Advance, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 3,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "������", "Sprites/LogoCards/������",
                0,
                defStance, Stance.Advance, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 3,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "����� � ��������",
                "Sprites/LogoCards/��������������", 1, advAttStance, Stance.Defensive, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.Enemy,
                "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "����� � ��������",
                "Sprites/LogoCards/��������������", 1, advAttStance, Stance.Defensive, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.Enemy,
                "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "���������� ����",
                "Sprites/LogoCards/��������������", 1, attStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 4, EnumCard.CardEffect.DiscardEnemy, 1, EnumCard.TargetType.Enemy,
                "���� ������ �������� ���� ����� � ���� �� �����", EnumCard.CardRestriction.Retiarius));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "���������� ����",
                "Sprites/LogoCards/��������������", 1, attStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 4, EnumCard.CardEffect.DiscardEnemy, 1, EnumCard.TargetType.Enemy,
                "���� ������ �������� ���� ����� � ���� �� �����", EnumCard.CardRestriction.Retiarius));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "���������� ����",
                "Sprites/LogoCards/��������������", 1, attStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 4, EnumCard.CardEffect.DiscardEnemy, 1, EnumCard.TargetType.Enemy,
                "���� ������ �������� ���� ����� � ���� �� �����", EnumCard.CardRestriction.Retiarius));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "���������� ����",
                "Sprites/LogoCards/��������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.NearCardDrow, 1, EnumCard.TargetType.Enemy,
                "���� �� �������� ������ ��� �����, �������� �����")); //����� �����
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "���������� ����",
                "Sprites/LogoCards/��������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.NearCardDrow, 1, EnumCard.TargetType.Enemy,
                "���� �� �������� ������ ��� �����, �������� �����")); //����� �����
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "����� ������",
                "Sprites/LogoCards/����������", 1,
                defAdvStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Movement, 1,
                EnumCard.CardEffect.Damage,
                2, EnumCard.TargetType.Enemy, "����� ������ ����������� ����� ����� �� ���� ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "����� ������",
                "Sprites/LogoCards/����������", 1,
                defAdvStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Movement, 1,
                EnumCard.CardEffect.Damage,
                2, EnumCard.TargetType.Enemy, "����� ������ ����������� ����� ����� �� ���� ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "����� ������",
                "Sprites/LogoCards/����������", 1,
                defAdvStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Movement, 1,
                EnumCard.CardEffect.Damage,
                2, EnumCard.TargetType.Enemy, "����� ������ ����������� ����� ����� �� ���� ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "����� ������",
                "Sprites/LogoCards/����������", 1,
                defAdvStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Movement, 1,
                EnumCard.CardEffect.Damage,
                2, EnumCard.TargetType.Enemy, "����� ������ ����������� ����� ����� �� ���� ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "��� �����",
                "Sprites/LogoCards/��������", 0,
                defAdvStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 1,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Retiarius, "��� �����",
                "Sprites/LogoCards/��������", 0,
                defAdvStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 1,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));

            //"�������"

            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "�������� �����",
                "Sprites/LogoCards/�������������",
                1, advAttStance, Stance.Raging, EnumCard.CardType.Attack, EnumCard.CardEffect.ChargeStart, 4,
                EnumCard.CardEffect.ChargeEnd, 4, EnumCard.TargetType.Enemy,
                "����� ������ ����������� ����� ����� �� ���������� �� 4 ������. -1 ���� �� ������ ���������� ����",
                EnumCard.CardRestriction.Scissor)); //����� �����
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "�������� �����",
                "Sprites/LogoCards/�������������",
                1, advStance, Stance.Raging, EnumCard.CardType.Attack, EnumCard.CardEffect.ChargeStart, 4,
                EnumCard.CardEffect.ChargeEnd, 4, EnumCard.TargetType.Enemy,
                "����� ������ ����������� ����� ����� �� ���������� �� 4 ������. -1 ���� �� ������ ���������� ����",
                EnumCard.CardRestriction.Scissor)); //����� �����
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "�������� �����",
                "Sprites/LogoCards/�������������",
                1, advStance, Stance.Raging, EnumCard.CardType.Attack, EnumCard.CardEffect.ChargeStart, 4,
                EnumCard.CardEffect.ChargeEnd, 4, EnumCard.TargetType.Enemy,
                "����� ������ ����������� ����� ����� �� ���������� �� 4 ������. -1 ���� ��  ������ ���������� ����",
                EnumCard.CardRestriction.Scissor)); //����� �����
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "��������� ����",
                "Sprites/LogoCards/�������������",
                1, advStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "��������� ����",
                "Sprites/LogoCards/�������������",
                1, advStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "��������� ����",
                "Sprites/LogoCards/�������������",
                1, advStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "Rip and tear",
                "Sprites/LogoCards/RipAndTear", 1,
                rageStance, Stance.Advance, EnumCard.CardType.Attack, EnumCard.CardEffect.DiscardSelf, 2,
                EnumCard.CardEffect.DamageAfterDiscard, 3, EnumCard.TargetType.Enemy,
                "����� ������ �������� �� ���� ����. +2 � ����� �� ������ ���������� �����",
                EnumCard.CardRestriction.Scissor)); //����� �����   
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "�������� �����",
                "Sprites/LogoCards/�������������",
                1, rageStance, Stance.Raging, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 2,
                EnumCard.CardEffect.ManaAdd,
                1, EnumCard.TargetType.Enemy, "�������� 1 ���� ��������", EnumCard.CardRestriction.Scissor));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "�������� ������",
                "Sprites/LogoCards/TakeIt", 0, advAttStance, Stance.Raging, EnumCard.CardType.Defense,
                EnumCard.CardEffect.Defense, 0, EnumCard.CardEffect.AliveCardDrow, 2, EnumCard.TargetType.This,
                "���� ���� ���� �����, �������� 2 �����", EnumCard.CardRestriction.Scissor));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "�������� ������",
                "Sprites/LogoCards/TakeIt", 0, advAttStance, Stance.Raging, EnumCard.CardType.Defense,
                EnumCard.CardEffect.Defense, 0, EnumCard.CardEffect.AliveCardDrow, 2, EnumCard.TargetType.This,
                "���� ���� ���� �����, �������� 2 �����", EnumCard.CardRestriction.Scissor));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "����������� ����",
                "Sprites/LogoCards/���������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 4, EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����",
                EnumCard.CardRestriction.Scissor));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "����������� ����",
                "Sprites/LogoCards/���������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 4, EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����",
                EnumCard.CardRestriction.Scissor));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "���� �������",
                "Sprites/LogoCards/�����������", 1,
                attStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.No,
                0,
                EnumCard.TargetType.Enemy));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "���� �������",
                "Sprites/LogoCards/�����������", 1,
                attStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.No,
                0,
                EnumCard.TargetType.Enemy));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Scissor, "���� �������",
                "Sprites/LogoCards/�����������", 1,
                attStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.No,
                0,
                EnumCard.TargetType.Enemy));


            //"���������"

            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "��������� �����",
                "Sprites/LogoCards/��������������", 1, anyStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 0, EnumCard.CardEffect.Stun, 2, EnumCard.TargetType.Enemy,
                "������� ������ ���� �� ���������. ��������� ������ �������� ��� �����",
                EnumCard.CardRestriction.Murmillo));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "��������� �����",
                "Sprites/LogoCards/��������������", 1, anyStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 0, EnumCard.CardEffect.Stun, 2, EnumCard.TargetType.Enemy,
                "������� ������ ���� �� ���������. ��������� ������ �������� ��� �����",
                EnumCard.CardRestriction.Murmillo));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "��������� �����",
                "Sprites/LogoCards/��������������", 1, anyStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 0, EnumCard.CardEffect.Stun, 2, EnumCard.TargetType.Enemy,
                "������� ������ ���� �� ���������. ��������� ������ �������� ��� �����",
                EnumCard.CardRestriction.Murmillo));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "����", "Sprites/LogoCards/����", 0,
                defStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 2,
                EnumCard.CardEffect.No, 0, EnumCard.TargetType.This, "+1 � ������, ���� ���� ���� �������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "����", "Sprites/LogoCards/����", 0,
                defStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 2,
                EnumCard.CardEffect.No, 0, EnumCard.TargetType.This, "+1 � ������, ���� ���� ���� �������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "����", "Sprites/LogoCards/����", 0,
                defStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 2,
                EnumCard.CardEffect.No, 0, EnumCard.TargetType.This, "+1 � ������, ���� ���� ���� �������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "����������� �����",
                "Sprites/LogoCards/����������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.DamageFinisher, 2, EnumCard.CardEffect.No, 0, EnumCard.TargetType.Enemy,
                "+1 � ����� �� ������ �����, ����������� � ��� ���������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "����������� �����",
                "Sprites/LogoCards/����������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.DamageFinisher, 2, EnumCard.CardEffect.No, 0, EnumCard.TargetType.Enemy,
                "+1 � ����� �� ������ �����, ����������� � ��� ���������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "������������",
                "Sprites/LogoCards/������������", 1,
                anyStance, Stance.Defensive, EnumCard.CardType.Attack, EnumCard.CardEffect.PushBackEnemy, 2,
                EnumCard.CardEffect.CardDrow, 2, EnumCard.TargetType.Enemy, "����������� ����� �� 2 �����. �������� 2 �����",
                EnumCard.CardRestriction.Murmillo));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "������������",
                "Sprites/LogoCards/������������", 1,
                anyStance, Stance.Defensive, EnumCard.CardType.Attack, EnumCard.CardEffect.PushBackEnemy, 2,
                EnumCard.CardEffect.CardDrow, 2, EnumCard.TargetType.Enemy, "����������� ����� �� 2 �����. �������� 2 �����",
                EnumCard.CardRestriction.Murmillo));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "������������",
                "Sprites/LogoCards/������������", 1,
                anyStance, Stance.Defensive, EnumCard.CardType.Attack, EnumCard.CardEffect.PushBackEnemy, 2,
                EnumCard.CardEffect.CardDrow, 2, EnumCard.TargetType.Enemy, "����������� ����� �� 2 �����. �������� 2 �����",
                EnumCard.CardRestriction.Murmillo));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "���� �������",
                "Sprites/LogoCards/�����������", 1,
                attStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.No,
                0,
                EnumCard.TargetType.Enemy));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "���� �������",
                "Sprites/LogoCards/�����������", 1,
                attStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.No,
                0,
                EnumCard.TargetType.Enemy));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "����������",
                "Sprites/LogoCards/����������", 0,
                advStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 1,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.This,
                "+1 � ������, ���� ���� ���� �������. �������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "����������",
                "Sprites/LogoCards/����������", 0,
                advStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 1,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.This,
                "+1 � ������, ���� ���� ���� �������. �������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "��������� ����",
                "Sprites/LogoCards/�������������",
                1, advStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Murmillo, "��������� ����",
                "Sprites/LogoCards/�������������",
                1, advStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.Enemy, "�������� �����"));


            //"��������"

            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "������",
                "Sprites/LogoCards/������", 0,
                defStance, Stance.Advance, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 3,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "������",
                "Sprites/LogoCards/������", 0,
                defStance, Stance.Advance, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 3,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����", "Sprites/LogoCards/����", 0,
                defStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 2,
                EnumCard.CardEffect.No, 1, EnumCard.TargetType.This, "+1 � ������, ���� ���� ���� �������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����", "Sprites/LogoCards/����", 0,
                defStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 2,
                EnumCard.CardEffect.No, 1, EnumCard.TargetType.This, "+1 � ������, ���� ���� ���� �������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����� ������",
                "Sprites/LogoCards/����������",
                1, defAdvStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Movement, 1,
                EnumCard.CardEffect.Damage, 2, EnumCard.TargetType.Enemy, "����� ������ ����������� ����� ����� �� ���� ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����� ������",
                "Sprites/LogoCards/����������",
                1, defAdvStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Movement, 1,
                EnumCard.CardEffect.Damage, 2, EnumCard.TargetType.Enemy, "����� ������ ����������� ����� ����� �� ���� ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����� ������",
                "Sprites/LogoCards/����������",
                1, defAdvStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Movement, 1,
                EnumCard.CardEffect.Damage, 2, EnumCard.TargetType.Enemy, "����� ������ ����������� ����� ����� �� ���� ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����������",
                "Sprites/LogoCards/����������", 0,
                advStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 1,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.This,
                "+1 � ������, ���� ���� ���� �������. �������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����������",
                "Sprites/LogoCards/����������", 0,
                advStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 1,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.This,
                "+1 � ������, ���� ���� ���� �������. �������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����� � ��������",
                "Sprites/LogoCards/��������������", 1, advAttStance, Stance.Defensive, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.Enemy,
                "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "����� � ��������",
                "Sprites/LogoCards/��������������", 1, advAttStance, Stance.Defensive, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.Enemy,
                "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "���������� ����",
                "Sprites/LogoCards/��������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.NearCardDrow, 1, EnumCard.TargetType.Enemy,
                "���� �� �������� ������ ��� �����, �������� �����")); //����� �����
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "���������� ����",
                "Sprites/LogoCards/��������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.NearCardDrow, 1, EnumCard.TargetType.Enemy,
                "���� �� �������� ������ ��� �����, �������� �����")); //����� �����
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "�������������",
                "Sprites/LogoCards/�������������", 1, attStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Movement, 2, EnumCard.CardEffect.Damage, 4, EnumCard.TargetType.Enemy,
                "����� ������ ����������� ����� ����� �� ���� ����", EnumCard.CardRestriction.Hoplomachus));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "�������������",
                "Sprites/LogoCards/�������������", 1, attStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Movement, 2, EnumCard.CardEffect.Damage, 4, EnumCard.TargetType.Enemy,
                "����� ������ ����������� ����� ����� �� ���� ����", EnumCard.CardRestriction.Hoplomachus));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Hoplomachus, "�������������",
                "Sprites/LogoCards/�������������", 1, attStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Movement, 2, EnumCard.CardEffect.Damage, 4, EnumCard.TargetType.Enemy,
                "����� ������ ����������� ����� ����� �� ���� ����", EnumCard.CardRestriction.Hoplomachus));

            //"�������"
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "������",
                    "Sprites/LogoCards/������", 0,
                    defStance, Stance.Advance, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 3,
                    EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "������",
                    "Sprites/LogoCards/������", 0,
                    defStance, Stance.Advance, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 3,
                    EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "������",
                    "Sprites/LogoCards/������", 0,
                    defStance, Stance.Advance, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 3,
                    EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "����� � ��������",
                "Sprites/LogoCards/��������������", 1, advAttStance, Stance.Defensive, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.Enemy,
                "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "����� � ��������",
                "Sprites/LogoCards/��������������", 1, advAttStance, Stance.Defensive, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.Enemy,
                "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "��� �����",
                "Sprites/LogoCards/��������", 0,
                defAdvStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 1,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "��� �����",
                "Sprites/LogoCards/��������", 0,
                defAdvStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 1,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "��� �����",
                "Sprites/LogoCards/��������", 0,
                defAdvStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 1,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "����������� ������",
                "Sprites/LogoCards/�����������������", 0, anyStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Movement, 1, EnumCard.CardEffect.Damage, 2, EnumCard.TargetType.Enemy,
                "�������� 1 ��. ����� ������ ����������� ����� ����� �� 1 ����", EnumCard.CardRestriction.Dimacher));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "����������� ������",
                "Sprites/LogoCards/�����������������", 0, anyStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Movement, 1, EnumCard.CardEffect.Damage, 2, EnumCard.TargetType.Enemy,
                "�������� 1 ��. ����� ������ ����������� ����� ����� �� 1 ����", EnumCard.CardRestriction.Dimacher));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "����������� ������",
                "Sprites/LogoCards/�����������������", 0, anyStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Movement, 1, EnumCard.CardEffect.Damage, 2, EnumCard.TargetType.Enemy,
                "�������� 1 ��. ����� ������ ����������� ����� ����� �� 1 ����", EnumCard.CardRestriction.Dimacher));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "����������� ������",
                "Sprites/LogoCards/�����������������", 0, anyStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Movement, 1, EnumCard.CardEffect.Damage, 2, EnumCard.TargetType.Enemy,
                "�������� 1 ��. ����� ������ ����������� ����� ����� �� 1 ����", EnumCard.CardRestriction.Dimacher));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "����������� ������",
                "Sprites/LogoCards/�����������������", 0, anyStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Movement, 1, EnumCard.CardEffect.Damage, 2, EnumCard.TargetType.Enemy,
                "�������� 1 ��. ����� ������ ����������� ����� ����� �� 1 ����", EnumCard.CardRestriction.Dimacher));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "����������� ������",
                "Sprites/LogoCards/�����������������", 0, anyStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Movement, 1, EnumCard.CardEffect.Damage, 2, EnumCard.TargetType.Enemy,
                "�������� 1 ��. ����� ������ ����������� ����� ����� �� 1 ����", EnumCard.CardRestriction.Dimacher));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "����� �������",
                "Sprites/LogoCards/������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.WhirlwindDamage, 1, EnumCard.TargetType.Enemy,
                "��� ���������� �� �������� ������� ����� �������� �����, ����� ������ 1 ��������", EnumCard.CardRestriction.Dimacher, true));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "����� �������",
                "Sprites/LogoCards/������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.WhirlwindDamage, 1, EnumCard.TargetType.Enemy,
                "��� ���������� �� �������� ������� ����� �������� �����, ����� ������ 1 ��������", EnumCard.CardRestriction.Dimacher, true));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Dimacher, "����� �������",
                "Sprites/LogoCards/������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.WhirlwindDamage, 1, EnumCard.TargetType.Enemy,
                "��� ���������� �� �������� ������� ����� �������� �����, ����� ������ 1 ��������", EnumCard.CardRestriction.Dimacher, true));

            //"�����"
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "��� �����",
                "Sprites/LogoCards/��������", 0,
                defAdvStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 1,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "��� �����",
                "Sprites/LogoCards/��������", 0,
                defAdvStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 1,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "��� �����",
                "Sprites/LogoCards/��������", 0,
                defAdvStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 1,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "��� �����",
                "Sprites/LogoCards/��������", 0,
                defAdvStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 1,
                EnumCard.CardEffect.Movement, 1, EnumCard.TargetType.This, "����� ����� ����������� ����� ����� �� 1 ����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "���� �������",
                "Sprites/LogoCards/�����������", 1,
                attStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.No,
                0,
                EnumCard.TargetType.Enemy));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "���� �������",
                "Sprites/LogoCards/�����������", 1,
                attStance, Stance.Attacking, EnumCard.CardType.Attack, EnumCard.CardEffect.Damage, 3, EnumCard.CardEffect.No,
                0,
                EnumCard.TargetType.Enemy));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "������������ �����",
                "Sprites/LogoCards/�����������������", 1, anyStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.ShieldedRush, 1, EnumCard.CardEffect.Damage, 1, EnumCard.TargetType.Enemy, 
                "����� ������ ��������� ����� ����� �� 1 ����. ���� ���� ���� �������, ���� ������ �������� 1 �����."));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "������������ �����",
                "Sprites/LogoCards/�����������������", 1, anyStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.ShieldedRush, 1, EnumCard.CardEffect.Damage, 1, EnumCard.TargetType.Enemy,
                "����� ������ ��������� ����� ����� �� 1 ����. ���� ���� ���� �������, ���� ������ �������� 1 �����."));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "������������ �����",
                "Sprites/LogoCards/�����������������", 1, anyStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.ShieldedRush, 1, EnumCard.CardEffect.Damage, 1, EnumCard.TargetType.Enemy,
                "����� ������ ��������� ����� ����� �� 1 ����. ���� ���� ���� �������, ���� ������ �������� 1 �����."));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "������ �������",
                "Sprites/LogoCards/�������������", 1, advAttStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.RangedAttack, 7, EnumCard.CardEffect.No, 0, EnumCard.TargetType.Enemy,
                "�����������. ��������� ���� ����� ����� 5 ������. -2 �����, ���� ���� � ����������� ���� ����� ���������", EnumCard.CardRestriction.Veles, true));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "������ �������",
                "Sprites/LogoCards/�������������", 1, advAttStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.RangedAttack, 7, EnumCard.CardEffect.No, 0, EnumCard.TargetType.Enemy,
                "�����������. ��������� ���� ����� ����� 5 ������. -2 �����, ���� ���� � ����������� ���� ����� ���������", EnumCard.CardRestriction.Veles, true));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "������ �������",
                "Sprites/LogoCards/�������������", 1, advAttStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.RangedAttack, 7, EnumCard.CardEffect.No, 0, EnumCard.TargetType.Enemy,
                "�����������. ��������� ���� ����� ����� 5 ������. -2 �����, ���� ���� � ����������� ���� ����� ���������", EnumCard.CardRestriction.Veles, true));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "������ �������",
                "Sprites/LogoCards/�������������", 1, advAttStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.RangedAttack, 7, EnumCard.CardEffect.No, 0, EnumCard.TargetType.Enemy,
                "�����������. ��������� ���� ����� ����� 5 ������. -2 �����, ���� ���� � ����������� ���� ����� ���������", EnumCard.CardRestriction.Veles, true));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "������ �������",
                "Sprites/LogoCards/�������������", 1, advAttStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.RangedAttack, 7, EnumCard.CardEffect.No, 0, EnumCard.TargetType.Enemy,
                "�����������. ��������� ���� ����� ����� 5 ������. -2 �����, ���� ���� � ����������� ���� ����� ���������", EnumCard.CardRestriction.Veles, true));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "����������� ����",
                "Sprites/LogoCards/���������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.Movement, 3, EnumCard.TargetType.Enemy,
                "����� ����� ����������� ����� ����� �� 3 �����", EnumCard.CardRestriction.Veles));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "����������� ����",
                "Sprites/LogoCards/���������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.Movement, 3, EnumCard.TargetType.Enemy,
                "����� ����� ����������� ����� ����� �� 3 �����", EnumCard.CardRestriction.Veles));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "����������� ����",
                "Sprites/LogoCards/���������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.Movement, 3, EnumCard.TargetType.Enemy,
                "����� ����� ����������� ����� ����� �� 3 �����", EnumCard.CardRestriction.Veles));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "�����",
                "Sprites/LogoCards/�����", 0,
                defStance, Stance.Advance, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 2,
                EnumCard.CardEffect.Movement, 4, EnumCard.TargetType.This, "����� ��������� ����� ����������� ����� ����� �� 4 �����", EnumCard.CardRestriction.Veles));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "�����",
                "Sprites/LogoCards/�����", 0,
                defStance, Stance.Advance, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 2,
                EnumCard.CardEffect.Movement, 4, EnumCard.TargetType.This, "����� ��������� ����� ����������� ����� ����� �� 4 �����", EnumCard.CardRestriction.Veles));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Veles, "�����",
                "Sprites/LogoCards/�����", 0,
                defStance, Stance.Advance, EnumCard.CardType.Defense, EnumCard.CardEffect.Defense, 2,
                EnumCard.CardEffect.Movement, 4, EnumCard.TargetType.This, "����� ��������� ����� ����������� ����� ����� �� 4 �����", EnumCard.CardRestriction.Veles));


            //"�������"
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "������������ �����",
                "Sprites/LogoCards/�����������������", 1, anyStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.ShieldedRush, 1, EnumCard.CardEffect.Damage, 1, EnumCard.TargetType.Enemy,
                "����� ������ ��������� ����� ����� �� 1 ����. ���� ���� ���� �������, ���� ������ �������� 1 �����."));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "������������ �����",
                "Sprites/LogoCards/�����������������", 1, anyStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.ShieldedRush, 1, EnumCard.CardEffect.Damage, 1, EnumCard.TargetType.Enemy,
                "����� ������ ��������� ����� ����� �� 1 ����. ���� ���� ���� �������, ���� ������ �������� 1 �����."));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "������������ �����",
                "Sprites/LogoCards/�����������������", 1, anyStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.ShieldedRush, 1, EnumCard.CardEffect.Damage, 1, EnumCard.TargetType.Enemy,
                "����� ������ ��������� ����� ����� �� 1 ����. ���� ���� ���� �������, ���� ������ �������� 1 �����."));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "����", "Sprites/LogoCards/����", 0,
                defStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 2,
                EnumCard.CardEffect.No, 0, EnumCard.TargetType.This, "+1 � ������, ���� ���� ���� �������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "����", "Sprites/LogoCards/����", 0,
                defStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 2,
                EnumCard.CardEffect.No, 0, EnumCard.TargetType.This, "+1 � ������, ���� ���� ���� �������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "����������� �����",
                "Sprites/LogoCards/����������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.DamageFinisher, 2, EnumCard.CardEffect.No, 0, EnumCard.TargetType.Enemy,
                "+1 � ����� �� ������ �����, ����������� � ��� ���������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "����������� �����",
                "Sprites/LogoCards/����������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.DamageFinisher, 2, EnumCard.CardEffect.No, 0, EnumCard.TargetType.Enemy,
                "+1 � ����� �� ������ �����, ����������� � ��� ���������"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "����������",
                "Sprites/LogoCards/����������", 0,
                advStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 1,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.This,
                "+1 � ������, ���� ���� ���� �������. �������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "����������",
                "Sprites/LogoCards/����������", 0,
                advStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 1,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.This,
                "+1 � ������, ���� ���� ���� �������. �������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "����������",
                "Sprites/LogoCards/����������", 0,
                advStance, Stance.Defensive, EnumCard.CardType.Defense, EnumCard.CardEffect.ShieldedDefense, 1,
                EnumCard.CardEffect.CardDrow, 1, EnumCard.TargetType.This,
                "+1 � ������, ���� ���� ���� �������. �������� �����"));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "����������� ������",
                "Sprites/LogoCards/�����������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.DealRawDamage, 3, EnumCard.CardEffect.No, 0, EnumCard.TargetType.Enemy,
                "�����������. ���� ���� ����� �� ����� ���� ������������� �������������� ��������� � ������� ����", EnumCard.CardRestriction.Thraex, true));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "����������� ������",
                "Sprites/LogoCards/�����������������", 1, attStance, Stance.Advance, EnumCard.CardType.Attack,
                EnumCard.CardEffect.DealRawDamage, 3, EnumCard.CardEffect.No, 0, EnumCard.TargetType.Enemy,
                "�����������. ���� ���� ����� �� ����� ���� ������������� �������������� ��������� � ������� ����", EnumCard.CardRestriction.Thraex, true));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "�������� ����",
                "Sprites/LogoCards/������������", 1, advAttStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.DiscardEnemy, 1, EnumCard.TargetType.Enemy,
                "���� ������ �������� �����", EnumCard.CardRestriction.Thraex));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "�������� ����",
                "Sprites/LogoCards/������������", 1, advAttStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.DiscardEnemy, 1, EnumCard.TargetType.Enemy,
                "���� ������ �������� �����", EnumCard.CardRestriction.Thraex));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "�������� ����",
                "Sprites/LogoCards/������������", 1, advAttStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.Damage, 2, EnumCard.CardEffect.DiscardEnemy, 1, EnumCard.TargetType.Enemy,
                "���� ������ �������� �����", EnumCard.CardRestriction.Thraex));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "� ������ �����",
                "Sprites/LogoCards/������������", 1, attStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.DoubleDamage, 4, EnumCard.CardEffect.No, 0, EnumCard.TargetType.Enemy,
                "���� � ��������� ��� ���� �� ����, ������� ���� ���� �����", EnumCard.CardRestriction.Thraex));
            CardManager.AllCards.Add(new Card(EnumCard.CardRestriction.Thraex, "� ������ �����",
                "Sprites/LogoCards/������������", 1, attStance, Stance.Attacking, EnumCard.CardType.Attack,
                EnumCard.CardEffect.DoubleDamage, 4, EnumCard.CardEffect.No, 0, EnumCard.TargetType.Enemy,
                "���� � ��������� ��� ���� �� ����, ������� ���� ���� �����", EnumCard.CardRestriction.Thraex));
        }
    }
}