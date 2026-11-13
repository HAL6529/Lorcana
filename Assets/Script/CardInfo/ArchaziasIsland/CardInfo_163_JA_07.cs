using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_163_JA_07 : CardInfo
{
    public CardInfo_163_JA_07()
    {
        this.cardNo = "163_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉwÉCÉwÉC";
        this.cardName2 = "íπóﬁÇÃäoê¡";
        this.power = 1;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaxineVee;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3, EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
