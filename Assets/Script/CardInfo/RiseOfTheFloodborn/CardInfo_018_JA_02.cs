using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_018_JA_02 : CardInfo
{
    public CardInfo_018_JA_02()
    {
        this.cardNo = "018_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉsÉOÉåÇ¡Ç∆";
        this.cardName2 = "Ç∆ÇƒÇ‡è¨Ç≥Ç¢ê∂Ç´ï®";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KierstenHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
