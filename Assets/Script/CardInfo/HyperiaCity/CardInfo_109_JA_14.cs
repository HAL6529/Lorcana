using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_109_JA_14 : CardInfo
{
    public CardInfo_109_JA_14()
    {
        this.cardNo = "109_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ペピータ";
        this.cardName2 = "ネコちゃん";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlejandroHernandez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
