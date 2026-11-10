using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_044_JA_03 : CardInfo
{
    public CardInfo_044_JA_03()
    {
        this.cardNo = "044_JA_03";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ñÇñ@ÇÃÇŸÇ§Ç´";
        this.cardName2 = "óxÇÈë|èúópãÔ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GiuliaRiva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Broom };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Fantasia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
