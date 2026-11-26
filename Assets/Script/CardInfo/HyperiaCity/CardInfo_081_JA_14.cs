using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_081_JA_14 : CardInfo
{
    public CardInfo_081_JA_14()
    {
        this.cardNo = "081_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "シア・カーン";
        this.cardName2 = "虎視眈々の実力者";
        this.power = 4;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DavidForrest;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> {  EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
