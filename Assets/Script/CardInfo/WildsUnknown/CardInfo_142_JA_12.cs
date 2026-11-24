using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_142_JA_12 : CardInfo
{
    public CardInfo_142_JA_12()
    {
        this.cardNo = "142_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ミラベル・マドリガル";
        this.cardName2 = "健気な娘";
        this.power = 3;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MilicaCelikovic;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
