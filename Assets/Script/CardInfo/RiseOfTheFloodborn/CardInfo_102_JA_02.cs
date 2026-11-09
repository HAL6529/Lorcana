using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_102_JA_02 : CardInfo
{
    public CardInfo_102_JA_02()
    {
        this.cardNo = "102_JA_02";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ÉâÉeÉBÉKÉìÇÃÇ∑ÇÒÇŒÇÁÇµÇ¢ÉèÉi";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
