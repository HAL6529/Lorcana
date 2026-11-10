using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_045_JA_03 : CardInfo
{
    public CardInfo_045_JA_03()
    {
        this.cardNo = "045_JA_03";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ñÇñ@ÇÃÇŸÇ§Ç´";
        this.cardName2 = "Ç∑ÇŒÇ‚Ç¢ê¥ë|åW";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Broom };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Fantasia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
