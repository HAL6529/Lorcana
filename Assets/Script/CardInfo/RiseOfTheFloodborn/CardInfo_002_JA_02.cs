using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_002_JA_02 : CardInfo
{
    public CardInfo_002_JA_02()
    {
        this.cardNo = "002_JA_02";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "クリストファー・ロビン";
        this.cardName2 = "冒険者";
        this.power = 2;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber};
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
