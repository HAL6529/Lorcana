using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_195_JA_02 : CardInfo
{
    public CardInfo_195_JA_02()
    {
        this.cardNo = "195_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "‰¤Žq";
        this.cardName2 = "Œˆ‚µ‚Ä‚ ‚«‚ç‚ß‚È‚¢";
        this.power = 1;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard, EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
