using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_018_JA_08 : CardInfo
{
    public CardInfo_018_JA_08()
    {
        this.cardNo = "018_JA_08";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ボゴ署長";
        this.cardName2 = "捜査指揮官";
        this.power = 5;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NicolaSaviori;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
