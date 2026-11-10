using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_161_JA_02 : CardInfo
{
    public CardInfo_161_JA_02()
    {
        this.cardNo = "161_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "Ç≠Ç‹ÇÃÉvÅ[Ç≥ÇÒ";
        this.cardName2 = "Ç©ÇÒÇ™Ç¶Ç≤Ç∆ÇµÇƒÇÈÇÃ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RiantiHidayat;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
