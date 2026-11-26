using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_106_JA_14 : CardInfo
{
    public CardInfo_106_JA_14()
    {
        this.cardNo = "106_JA_14";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ヘクター・リヴェラ";
        this.cardName2 = "世界に届いた歌";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
