using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_144_JA_04 : CardInfo
{
    public CardInfo_144_JA_04()
    {
        this.cardNo = "144_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フランダー";
        this.cardName2 = "収集家のツレ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JamesCMulligan;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
