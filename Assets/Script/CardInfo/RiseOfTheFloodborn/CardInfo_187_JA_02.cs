using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_187_JA_02 : CardInfo
{
    public CardInfo_187_JA_02()
    {
        this.cardNo = "187_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉäÅ[ÅEÉVÉÉÉì";
        this.cardName2 = "ã|èpã≥äØ";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
