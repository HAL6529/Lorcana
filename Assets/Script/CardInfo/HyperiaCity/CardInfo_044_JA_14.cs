using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_044_JA_14 : CardInfo
{
    public CardInfo_044_JA_14()
    {
        this.cardNo = "044_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ママ・ココ";
        this.cardName2 = "公園へお出かけ";
        this.power = 3;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DianaDiz;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Coco;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
