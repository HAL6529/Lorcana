using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_088_JA_02 : CardInfo
{
    public CardInfo_088_JA_02()
    {
        this.cardNo = "088_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉsÅ[Ég";
        this.cardName2 = "ÇÌÇÈÇ‡ÇÒ";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HedvigH_S;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
