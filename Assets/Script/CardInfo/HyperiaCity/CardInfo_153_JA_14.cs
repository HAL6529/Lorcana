using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_153_JA_14 : CardInfo
{
    public CardInfo_153_JA_14()
    {
        this.cardNo = "153_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ダッチェス";
        this.cardName2 = "おハイソキャット";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValentinaGraziuso;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
