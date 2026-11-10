using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_170_JA_02 : CardInfo
{
    public CardInfo_170_JA_02()
    {
        this.cardNo = "170_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉCÉèÉVÇÃãÛÇ´ä ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.PeterBrockhammer;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
