﻿namespace Core
{
    public enum SpellCastResult
    {
        Success,
        AffectingCombat,
        AlreadyAtFullHealth,
        AlreadyAtFullMana,
        AlreadyAtFullPower,
        BadImplicitTargets,
        BadTargets,
        CantStealth,
        CasterAurastate,
        CasterDead,
        CasterNotExists,
        Confused,
        DontReport,
        Error,
        Falling,
        Fleeing,
        LowLevel,
        Highlevel,
        Immune,
        IncorrectArea,
        Interrupted,
        LevelRequirement,
        LineOfSight,
        Moving,
        NotBehind,
        NotFlying,
        NotHere,
        NotInfront,
        NotInControl,
        NotKnown,
        NotReady,
        NotStanding,
        NoAmmo,
        NoChargesRemain,
        NoComboPoints,
        NoPower,
        NothingToDispel,
        NothingToSteal,
        OnlyStealthed,
        OnlyUnderwater,
        OutOfRange,
        Pacified,
        Possessed,
        Rooted,
        Silenced,
        SpellInProgress,
        SpellUnavailable,
        Stunned,
        TargetsDead,
        TargetAurastate,
        TargetEnemy,
        TargetEnraged,
        TargetFriendly,
        TargetIsPlayer,
        TargetNotDead,
        TargetNotPlayer,
        TargetNoPockets,
        TargetNoWeapons,
        TargetNoRangedWeapons,
        TooClose,
        TryAgain,
        VisionObscured,
        DamageImmune,
        PreventedByMechanic,
        BmOrInvisgod,
        CustomError,
        NoValidTargets,
        TargetCannotBeResurrected,
        Unknown
    }
}
