using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_138_JA_10 : CardInfo
{
    public CardInfo_138_JA_10()
    {
        this.cardNo = "138_JA_10";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ヘン・ウェン";
        this.cardName2 = "予言豚";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Kapik;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
