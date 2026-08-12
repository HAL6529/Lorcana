using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_149_JA_01 : CardInfo
{
    public CardInfo_149_JA_01()
    {
        this.cardNo = "149_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ジャスミン";
        this.cardName2 = "アグラバーの女王";
        this.power = 2;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Filipe Laurentino";
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
