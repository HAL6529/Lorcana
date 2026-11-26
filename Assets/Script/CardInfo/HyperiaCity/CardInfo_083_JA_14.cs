using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_083_JA_14 : CardInfo
{
    public CardInfo_083_JA_14()
    {
        this.cardNo = "083_JA_14";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "シア・カーン";
        this.cardName2 = "冷酷非情の実業家";
        this.power = 7;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CaseyJoOcean;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
