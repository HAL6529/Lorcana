using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_039_JA_06 : CardInfo
{
    public CardInfo_039_JA_06()
    {
        this.cardNo = "039_JA_06";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉVÉXÅ[";
        this.cardName2 = "êÖÇìæÇΩó¥";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Deity, EnumController.Class.Dragon };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
