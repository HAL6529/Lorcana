using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_002_JA_14 : CardInfo
{
    public CardInfo_002_JA_14()
    {
        this.cardNo = "002_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アブエリータ";
        this.cardName2 = "愛情深いおばあちゃん";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.PepeDelgadoNavarro;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
