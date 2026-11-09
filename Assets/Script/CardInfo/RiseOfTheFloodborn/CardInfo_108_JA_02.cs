using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_108_JA_02 : CardInfo
{
    public CardInfo_108_JA_02()
    {
        this.cardNo = "108_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フィジット";
        this.cardName2 = "ラティガンの手下";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GiuliaRiva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
