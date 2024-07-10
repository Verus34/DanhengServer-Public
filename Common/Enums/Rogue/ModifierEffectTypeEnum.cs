﻿namespace EggLink.DanhengServer.Enums.Rogue
{
    /// <summary>
    /// Original Name: ModifierEffectType
    /// </summary>
    public enum ModifierEffectTypeEnum
    {
        // Fields
        None = 0,
        AddMazeBuff = 1,
        MoveChessRogueBoard = 2,
        MoveCellWinMiracle = 3,
        ReRandomSameBlockCell = 4,
        TurnToLastCell = 5,
        ReRandomAroundCell = 6,
        CellVictoryAndToTrap = 7,
        SelectAndAddCellMark = 8,
        SelectAndToFightCell = 9,
        RogueBuffLevelUpOnWin = 10,
        ExtraRogueMoney = 11,
        ExtraRogueBuff = 12,
        DoubleNextMoveCell = 13,
        EnsureMoveCellCount = 14,
        AddAccumulateMazeBuff = 15,
        ExtraMarkAndRandomSwap = 16,
        LockMarkCell = 17,
        MoveMarkCellUpgradeReward = 18,
        SetColCanMove = 19,
        SetMarkToRandomCell = 20,
        ExtraMoneyAndRandomSwap = 21,
        ReplicateAroundCell = 22,
        ReplicateLastCell = 23,
        ReplicateCellToAround = 24,
        AllowMoveToReplicateCell = 25,
        ReplicateAllAroundCell = 26,
        SetCellTypeAndTakeReward = 27,
        ReRandomEmptyCell = 28,
        SelectMiracleToEmpty = 29,
        SelectBuffToEmpty = 30,
        TurnFightCellToEmpty = 31,
        TurnEventCellToEmpty = 32,
        TrunEmptyToReward = 33,
        EnterEmptyGetMoney = 34,
        ProtectCellNoCollapse = 35,
        SelectCellToProtect = 36,
        ProtectCollaspeCell = 37,
        GetMoneyByProtectCell = 38,
        RandomGenSwarm = 39,
        SetBlocktype = 40,
        SetMarkType = 41,
        ToRandomBlockType = 42,
        MoveToSwarmGetBuff = 43,
        GetHelpOnEnterCell = 44,
        SelectCellGetHelp = 45,
        SelectAroundGetHelp = 46,
        AddAccumulateHurt = 47,
        FertileAeonGain = 48,
        EnhanceSeedCell = 49,
        SetSpecialType = 50,
        BenefitsBySeed = 51,
        RandomSetSpecialType = 52,
        RandomNeighborSpecialType = 53,
        SetNeighborSpecialType = 54,
        AddCellMazeBuff = 55,
        SelectExceptCellGetHelp = 56,
        SetAroundBlockType = 57,
        DestroyAeonGain = 58,
        AddMazeBuffByBlock = 59,
        EnterCellTriggerBuff = 60,
        StartBoardRandomSetBlockType = 61,
        StartBoardRandomSetSpecialType = 62,
        StartBoardRandomSetMarkType = 63,
        StartBoardSetMarkType = 64,
        StartBoardExpandBoard = 65,
        TriggerBuffOnBattleWin = 66,
        TriggerMiracleOnBattleWin = 67,
        TriggerBuffOnMove = 68,
        TriggerMiracleOnMove = 69,
        ExtraMoneyOnKillMonster = 70,
        ResetActionPointOnMoveByMark = 71,
        TriggerRandomMarkOnSetSpecialType = 72,
        ProtectSpecialCellAndTriggerMoney = 73,
        TriggerMoneyAndDoubleOnCollapse = 74,
        TriggerShopRandomFreeOnEnterCell = 75,
        AccumulateValue = 76,
        SelectCellToEmptyGetBuff = 77,
        TrunAroundToEmptyGetBuff = 78,
        SelectCellTurnAroundToEmpty = 79,
        IncAccumulateValueRate = 80,
        GiveupMiracleGetMoney = 81,
        ChangeActionPointByRange = 82,
        GetActionPointByMoney = 83,
        SetBlocktypeWithProbability = 84,
        SetSepcialTypeByReplicate = 85,
        ReplicateCurCellToSelectCell = 86,
        ReplicateSelectCellToAround = 87,
        ReRandomCellTypeGetMoney = 88,
        SetBlockTypeToAround = 89,
        ReplicateSelectCellToRandom = 90,
        SetBlockTypeToAroundWithCandidate = 91,
        SetBlockTypeWithCandidate = 92,
        SwapCellToCurAround = 93,
        SetBlockTypeGetMoney = 94,
        GetMoneyBySetBlockType = 95,
        SetMarkTypeWithCandidate = 96,
        TurnBlockTypeTriggerBuff = 97,
        SetBlockTypeBySelectMarkCell = 98,
        SetMarkCellTypeTakeReward = 99,
        ReplicateCurCellToRandom = 100,
        SwapMarkCellToAroundGetMoney = 101,
        TurnRandomCellBlockType = 102,
        SwapRandomCellToCurAround = 103,
        SetNearestBlockCanMove = 104,
        SetSpecialTypeCanMove = 105,
        SetMarkTypeCanMove = 106,
        RandomGenMark = 107,
        RandomSetMarkType = 108,
        RandomSetReplaceMarkType = 109,
        RandomGenMarkWithSpecialType = 110,
        SetAroundSpecialType = 111,
        RandomSetAroundSpecialType = 112,
        MoveSetCollapseSpecialType = 113,
        MoveSetAroundSpecialType = 114,
        TakeRewardBySpecialType = 115,
        AddActionPointOnMove = 116,
        TriggerBuffOnMoveSameBlock = 117,
        GetMoneyOnMoveSpecial = 118,
        TriggerBuffOnMoveMark = 119,
        RandomGenSpecialTypeOnMoveSpecial = 120,
        RandomGenMarkOnMoveMark = 121,
        StartBoardGetDiceCheatNum = 122,
        ChangeActionPoint = 123,
        ChangeActionPointOnMoveSpecial = 124,
        TriggerBuffByActionPointOnMove = 125,
        ReturnMoneyOnBuyGoods = 126,
        GetMoneyOnGetMiracle = 127,
        TriggerBuffMiracleOnMoveMark = 128,
        ActivateAllBuffSurface = 129,
        GetRerollNumOnMove = 130,
        SetCellTypeAndAddActionPoint = 131,
        GetMoneyActionPointOnAbandonMiracle = 132,
        AddActionPointOnGetMiracle = 133,
        AddActionPointOnSetCellType = 134,
        GetMoneyChangeActionPoint = 135,
        ShopDiscountOnTradeCell = 136,
        GetMoneyByMiracleCount = 137,
        GetMoneyOnSelectCellToTargetType = 138,
        GetMoneyOnEnterCell = 139,
        SetRandomCellToTargeType = 140,
        AddMiracleList = 141,
        ChangeSelectCellType = 142,
        GetMoneyOnAbandonMiracle = 143,
        GetMoneyOnMoveCollapse = 144,
        SetMarkOnSelectThenSwap = 145,
        AbandonReGetMiracle = 146,
        SelectSpecialCellEmptyTriggerBuff = 147,
        GetMoneyBySpecialCellCnt = 148,
        SelectCellLoseAroundSpecialAndGetMoney = 149,
        RandomSetSpecialCellBlockType = 150,
        SelectMarkCellToRandomMarkAndTriggerBuff = 151,
        TriggerBuffByMarkTypeCnt = 152,
        ReRandomMarkAndGenMark = 153,
        SelectCellLoseMarkAndGetMoney = 154,
        GetMoneyAndTriggerBuffOnMove = 155,
        GiveRandomBuffOnMove = 156,
        TriggerRogueBuffSelect = 201,
        TriggerRogueMiracleSelect = 202,
        GetItem = 203,
        UpRogueBuffLevel = 204,
        RecoverLineup = 205,
        TriggerRogueBuffReforge = 206,
        GetRogueMiracle = 207,
        GetAllRogueBuffInGroup = 208,
        TriggerBattle = 209,
        ReplaceBlock = 210,
        TriggerAreaShuffle = 211,
        TriggerMark = 212,
        TriggerExtension = 213,
        RandomReplaceBlock = 214,
        DestroyColList = 215,
        ChangeItemRatio = 401,
        ChangeCostRatio = 402,
        ExtraBuffRandomCount = 403,
        ChangeCurrentItemImmediately = 404,
        ExtraBuffSelectReduceNumber = 405,
        ExtraFreeBuffRoll = 406,
        SetSelectBuffLevel = 407,
        ChangePropDestructNumber = 408,
        AddMazeBuffAfterMonsterKill = 409,
        ReviveLineupAvatar = 410,
        SetSelectBuffGroupCount = 411,
        RepairRandomMiracle = 412,
        UpgradeRandomBuff = 413,
        ReplaceAllMiracles = 414,
        SetBattleWinOnBattleFail = 415,
        StartDestructPropExtraMiracle = 416,
        ChangeAllRogueAvatarLineupDataByCurrent = 417,
        SetSelectBuffRandomEnhance = 418,
        StartDestructPropRecord = 419,
        ChangePropHitResultRatio = 420,
        ChangeItemRatioOnNextRoom = 421,
        ChangeRogueShopDiscountRatio = 422,
        AddMazeBuffOnEnterCellWithBlockType = 423,
        GetItemWithFullHpCountAfterMonsterKill = 424,
        SetIsBattleTriggerNoBuffSelect = 425,
        MultipleMonsterDropItemRatio = 426,
        AddMiracleFromListOnBattleWin = 427,
        GetDiceRollNum = 428,
        AddCurAeonBuffWithRandomCnt = 429,
        ReplaceAllBuffs = 430,
        SelectMazeBuffOnSelectAeon = 431,
        TurnBlockTypeToTarget = 432,
        SetCountByConsumeItem = 433,
        StartDestructPropExtraBuff = 434,
        GetOrRemoveItemOnEnterRoom = 435,
        SetCountByEnterCellType = 436,
        StartEnhanceAndRollBuffRecord = 437,
        MultipleItemRatio = 438,
        AccumulateCoinRecord = 439,
        GetItemOnKillMonster = 440,
        ModifyAdventureRoomTime = 441,
        AdventureRoomExtraGroup = 442,
        GetCoinByBlockType = 443,
        SetDiceReRollNum = 444,
        SetDiceCheatNum = 445,
        SetDiceReRollFree = 446,
        RoomRepeatedSurfaceUseMiracle = 447,
        ModifyBuffTypeCount = 448,
        UseMiracleByEnterCellType = 449,
        ModifyDiceSurfaceWeightByRarity = 450,
        RefreshBuffSelectGuaranteedAeonBuff = 451,
        AddCoinOnStart = 501,
        AddDiceCheatCntOnStart = 502,
        AddCoinGiveupDice = 503,
        AddActionPointOnStart = 504,
        EnterLeaderCellFullSp = 505,
        EnterTopThreeNotLeaderCellLowMonsterHp = 506,
        EnterCellAddDiceExtraCnt = 507,
        TeachingLevelLatentRule = 601,
        RecordInfo = 602,
        BoardEvent = 603,
        GmMode = 604,
        NousTeachingRule = 605,
        SetChessRogueNextStartCellAdventureRoomType = 701,
        SetChessRogueNextCellAdventureRoomType = 702,
        ActivityEndlessGetRogueBuffOnFirstRoom = 801,
        ActivityEndlessGetRogueMiracleOnFirstRoom = 802,
        ActivityEndlessTriggerSelectBuffOnNextRoom = 803,
        ActivityEndlessTriggerSelectMiracleOnNextRoom = 804,
        ActivityEndlessMonsterKillSpecialDropBuffSelectRatio = 805,
        ActivityEndlessNoBuffSelectAndAddCoin = 806,
        ActivityEndlessGetRogueBuffByAeonOnFirstRoom = 807,
        ActivityEndlessTriggerSelectBuffOnFinishDialogue = 808,
        ActivityEndlessGetItemOnFinishDialogue = 810,
        ActivityEndlessShopGuaranteedAeonBuff = 811,
        ActivityEndlessFirstSelectGuaranteedAeonBuff = 812,
        ActivityEndlessTriggerSelectBuffOnBattleWin = 813,
        ChangeCellBlockType = 820,
        ForbidRepeatDiceFaceAsBefore = 821,
        ReplaceBossBpDecayGroup = 822,
        ReplaceBossBpMonsterAndFloorList = 823,
        SubActionPointOnStart = 824,
        SubExtraActionPointOnNegative = 825,
        ChangeCoinOnRerollBuff = 826,
        GetRogueMiracleOnEnterLayer = 827,
        ChangeRogueCoinOnStart = 828,
        ChangeDiceRepeatNumOnStart = 829,
        NoBuffSelect = 1000,
        ModifyItemOnBattleWin = 1001,
        AddItemOnEnterNextRoom = 1002,
        ModifyItemOnHitProp = 1003,
        AddItemOnBattleWin = 1004,
        TriggerSelectBuffOnMonsterKill = 1005,
        GetRogueCoinWithNotify = 1006,
        AddMazeBuffList = 1007,
        RemoveMazeBuffList = 1008,
        ModifyBuffShopBuffNum = 1009,
        ChangeRogueNpcWeight = 1010,
        PassiveIncreasingCounter = 1011,
    }
}
