namespace Card
{
    public class EnumCard
    {
        public enum CardRestriction
        {
            Universal,
            Retiarius,
            Hoplomachus,
            Murmillo,
            Scissor,
            Thraex,
            Veles,
            Dimacher
        }
        public enum TargetType
        {
            NoTarget,
            This,
            Enemy,
            Ally
        }

        public enum CardType
        {
            Attack,
            Defense
        }
        public enum CardEffect
        {
            Damage,
            DamageAfterDiscard,
            DamageFinisher,
            Defense,
            ShieldedDefense,
            Movement,
            CardDrow,
            AliveCardDrow,
            NearCardDrow,
            ManaAdd,
            ChargeStart,
            ChargeEnd,
            PushBackEnemy,
            Stun,
            CancelCard,
            DiscardEnemy,
            DiscardSelf,
            WhirlwindDamage,
            ShieldedRush,
            RangedAttack,
            DealRawDamage,
            DoubleDamage,
            No
        }
    }
}