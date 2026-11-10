using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_158_JA_04 : CardInfo
{
    public CardInfo_158_JA_04()
    {
        this.cardNo = "158_JA_04";
        this.inkCost = 9;
        this.availableInk = true;
        this.cardName1 = "トリトン王";
        this.cardName2 = "アトランティカの王者";
        this.power = 7;
        this.toughness = 9;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.ErinShin;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift6 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
