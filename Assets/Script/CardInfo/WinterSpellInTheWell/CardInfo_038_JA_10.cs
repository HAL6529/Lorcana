using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_038_JA_10 : CardInfo
{
    public CardInfo_038_JA_10()
    {
        this.cardNo = "038_JA_10";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ホーンド・キング";
        this.cardName2 = "非情なる悪魔";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KevinSidharta;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.King, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
