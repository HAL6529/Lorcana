using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_188_JA_02 : CardInfo
{
    public CardInfo_188_JA_02()
    {
        this.cardNo = "188_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "–‚–@‚Ì‚Ù‚¤‚«";
        this.cardName2 = "ŽY‹Æ—pƒ‚ƒfƒ‹";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Broom };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Fantasia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
