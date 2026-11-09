using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_186_JA_02 : CardInfo
{
    public CardInfo_186_JA_02()
    {
        this.cardNo = "186_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉçÅ[ÉåÉìÉX";
        this.cardName2 = "ìiÇ›ê[Ç¢è]é“";
        this.power = 0;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LuisHuerta;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
