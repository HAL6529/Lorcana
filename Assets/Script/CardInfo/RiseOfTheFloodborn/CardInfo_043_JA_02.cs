using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_043_JA_02 : CardInfo
{
    public CardInfo_043_JA_02()
    {
        this.cardNo = "043_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉwÉCÉwÉC";
        this.cardName2 = "ÇµÇ‘Ç∆Ç¢ë∂ç›";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
