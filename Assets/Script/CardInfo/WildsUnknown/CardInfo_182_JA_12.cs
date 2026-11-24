using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_182_JA_12 : CardInfo
{
    public CardInfo_182_JA_12()
    {
        this.cardNo = "182_JA_12";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ファットキャット";
        this.cardName2 = "犯罪猫";
        this.power = 6;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
